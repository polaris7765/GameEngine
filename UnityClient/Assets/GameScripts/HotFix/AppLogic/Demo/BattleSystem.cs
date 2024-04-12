using System.Collections;
using Cysharp.Threading.Tasks;
using AppLogic;
using EFFramework;
using UnityEngine;
using AudioType = EFFramework.AudioType;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

/// <summary>
/// 战斗房间
/// </summary>
[Update]
public class BattleSystem : BehaviourSingleton<BattleSystem>
{
    private enum ESteps
    {
        None,
        Ready,
        Spawn,
        WaitSpawn,
        WaitWave,
        GameOver,
    }

    private GameObject _roomRoot;

    // 关卡参数
    private const int EnemyCount = 10;
    private const int EnemyScore = 10;
    private const int AsteroidScore = 1;
    private readonly Vector3 _spawnValues = new Vector3(6, 0, 20);

    private readonly string[] _entityLocations = new string[]
    {
        "asteroid01", "asteroid02", "asteroid03", "enemy_ship"
    };

    private ESteps _steps = ESteps.None;
    private int _totalScore = 0;

    private int _waveSpawnCount = 0;
    //
    // private UniTimer _startWaitTimer = UniTimer.CreateOnceTimer(1f);
    // private UniTimer _spawnWaitTimer = UniTimer.CreateOnceTimer(0.75f);
    // private UniTimer _waveWaitTimer = UniTimer.CreateOnceTimer(4f);

    private float _startWaitTimer = 1f;
    private float _spawnWaitTimer = 0.75f;
    private float _waveWaitTimer = 4f;

    /// <summary>
    /// 加载房间
    /// </summary>
    public async UniTaskVoid LoadRoom()
    {
        _startWaitTimer = 1f;

        await UniTask.Yield();
        // 创建房间根对象
        _roomRoot = new GameObject("BattleRoom");

        // 加载背景音乐
        AppModule.Audio.Play(AudioType.Music, "music_background", true);

        // 创建玩家实体对象
        var handle = PoolManager.Instance.GetGameObject("player_ship",parent: _roomRoot.transform);
        var entity = handle.GetComponent<EntityPlayer>();

        // 显示战斗界面
        AppModule.UI.ShowUIAsync<UIBattleWindow>();
        
        // 监听应用事件
        AppEvent.AddEventListener<Vector3, Quaternion>(ActorEventDefine.PlayerDead, OnPlayerDead);
        AppEvent.AddEventListener<Vector3, Quaternion>(ActorEventDefine.EnemyDead, OnEnemyDead);
        AppEvent.AddEventListener<Vector3, Quaternion>(ActorEventDefine.AsteroidExplosion, OnAsteroidExplosion);
        AppEvent.AddEventListener<Vector3, Quaternion>(ActorEventDefine.PlayerFireBullet, OnPlayerFireBullet);
        AppEvent.AddEventListener<Vector3, Quaternion>(ActorEventDefine.EnemyFireBullet, OnEnemyFireBullet);

        _steps = ESteps.Ready;
    }

    /// <summary>
    /// 销毁房间
    /// </summary>
    public void DestroyRoom()
    {
        // 加载背景音乐
        AppModule.Audio.Stop(AudioType.Music, true);

        // if (_entitySpawner != null)
        // {
        // 	_entitySpawner.DestroyAll(true);
        // }

        if (_roomRoot != null)
            Object.Destroy(_roomRoot);

        AppModule.UI.CloseUI<UIBattleWindow>();
        // 监听应用事件
        AppEvent.RemoveEventListener<Vector3, Quaternion>(ActorEventDefine.PlayerDead, OnPlayerDead);
        AppEvent.RemoveEventListener<Vector3, Quaternion>(ActorEventDefine.EnemyDead, OnEnemyDead);
        AppEvent.RemoveEventListener<Vector3, Quaternion>(ActorEventDefine.AsteroidExplosion, OnAsteroidExplosion);
        AppEvent.RemoveEventListener<Vector3, Quaternion>(ActorEventDefine.PlayerFireBullet, OnPlayerFireBullet);
        AppEvent.RemoveEventListener<Vector3, Quaternion>(ActorEventDefine.EnemyFireBullet, OnEnemyFireBullet);
    }

    public override void Update()
    {
        UpdateRoom();
    }

    /// <summary>
    /// 更新房间
    /// </summary>
    public void UpdateRoom()
    {
        if (_steps == ESteps.None || _steps == ESteps.GameOver)
            return;

        if (_steps == ESteps.Ready)
        {
            _startWaitTimer -= Time.deltaTime;
            if (_startWaitTimer <= 0)
            {
                _steps = ESteps.Spawn;
            }
        }

        if (_steps == ESteps.Spawn)
        {
            var enemyLocation = _entityLocations[Random.Range(0, 4)];
            Vector3 spawnPosition = new Vector3(Random.Range(-_spawnValues.x, _spawnValues.x), _spawnValues.y, _spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;

            if (enemyLocation == "enemy_ship")
            {
                // 生成敌人实体
                var gameObject = PoolManager.Instance.GetGameObject(enemyLocation,parent: _roomRoot.transform);
                gameObject.transform.position = spawnPosition;
                gameObject.transform.rotation = spawnRotation;
                var entity = gameObject.GetComponent<EntityEnemy>();
                entity.InitEntity();
            }
            else
            {
                // 生成小行星实体
                var gameObject = PoolManager.Instance.GetGameObject(enemyLocation,parent: _roomRoot.transform);
                gameObject.transform.position = spawnPosition;
                gameObject.transform.rotation = spawnRotation;
                var entity = gameObject.GetComponent<EntityAsteroid>();
                entity.InitEntity();
            }

            _waveSpawnCount++;
            if (_waveSpawnCount >= EnemyCount)
            {
                _steps = ESteps.WaitWave;
            }
            else
            {
                _steps = ESteps.WaitSpawn;
            }
        }

        if (_steps == ESteps.WaitSpawn)
        {
            _spawnWaitTimer -= Time.deltaTime;
            if (_spawnWaitTimer <= 0)
            {
                _spawnWaitTimer = 0.75f;
                _steps = ESteps.Spawn;
            }
        }

        if (_steps == ESteps.WaitWave)
        {
            _waveWaitTimer -= Time.deltaTime;
            if (_waveWaitTimer <= 0)
            {
                _waveWaitTimer = 4f;
                _waveSpawnCount = 0;
                _steps = ESteps.Spawn;
            }
        }
    }


    #region 接收事件

    private void OnPlayerDead(Vector3 position, Quaternion rotation)
    {
        // 创建爆炸效果
        var gameObject = PoolManager.Instance.GetGameObject("explosion_player",parent: _roomRoot.transform);
        gameObject.transform.position = position;
        gameObject.transform.rotation = rotation;
        var entity = gameObject.GetComponent<EntityEffect>();
        entity.InitEntity();
        _steps = ESteps.GameOver;
        AppEvent.Send(ActorEventDefine.GameOver);
    }

    private void OnEnemyDead(Vector3 position, Quaternion rotation)
    {
        // 创建爆炸效果
        var gameObject = PoolManager.Instance.GetGameObject("explosion_enemy",parent: _roomRoot.transform);
        gameObject.transform.position = position;
        gameObject.transform.rotation = rotation;
        var entity = gameObject.GetComponent<EntityEffect>();
        entity.InitEntity();

        _totalScore += EnemyScore * 10;
        AppEvent.Send(ActorEventDefine.ScoreChange, _totalScore);
    }

    private void OnAsteroidExplosion(Vector3 position, Quaternion rotation)
    {
        // 创建爆炸效果
        var gameObject = PoolManager.Instance.GetGameObject("explosion_asteroid",parent: _roomRoot.transform);
        gameObject.transform.position = position;
        gameObject.transform.rotation = rotation;
        var entity = gameObject.GetComponent<EntityEffect>();
        entity.InitEntity();

        _totalScore += (AsteroidScore * 5);
        AppEvent.Send(ActorEventDefine.ScoreChange, _totalScore);
    }

    private void OnPlayerFireBullet(Vector3 position, Quaternion rotation)
    {
        // 创建子弹实体
        var gameObject = PoolManager.Instance.GetGameObject("player_bullet",parent: _roomRoot.transform);
        gameObject.transform.position = position;
        gameObject.transform.rotation = rotation;
        var entity = gameObject.GetComponent<EntityBullet>();
        entity.InitEntity();
    }

    private void OnEnemyFireBullet(Vector3 position, Quaternion rotation)
    {
        // 创建子弹实体
        var gameObject = PoolManager.Instance.GetGameObject("enemy_bullet",parent: _roomRoot.transform);
        gameObject.transform.position = position;
        gameObject.transform.rotation = rotation;
        var entity = gameObject.GetComponent<EntityBullet>();
        entity.InitEntity();
    }

    #endregion
}