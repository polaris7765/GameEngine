using AppBase;
using Cysharp.Threading.Tasks;
using EFFramework;

namespace AppLogic
{
    public class SceneController:Singleton<SceneController>
    {
        public void Init()
        {
            AppEvent.AddEventListener(SceneEvent.Login, EnterLoginScene);
            AppEvent.AddEventListener(SceneEvent.Theme, EnterThemeScene);
        }

        void OnDestroy()
        {
            AppEvent.RemoveEventListener(SceneEvent.Login, EnterLoginScene);
            AppEvent.RemoveEventListener(SceneEvent.Theme, EnterThemeScene);
        }

        private void EnterLoginScene()
        {
            StartAppLogin().Forget();
        }
        
        private void EnterThemeScene()
        {
            StartBattleRoom().Forget();
        }
        
        /// <summary>
        /// 开始应用业务层逻辑。
        /// <remarks>显示UI、加载场景等。</remarks>
        /// </summary>
        private async UniTaskVoid StartAppLogin()
        {
            await AppModule.Scene.LoadScene(SceneName.SCENE_LOGIN.ToString().ToLower()).ToUniTask();
            LoginSystem.Instance.LoadLogin().Forget();
        }

        /// <summary>
        /// 开始应用业务层逻辑。
        /// <remarks>显示UI、加载场景等。</remarks>
        /// </summary>
        private async UniTaskVoid StartBattleRoom()
        {
            await AppModule.Scene.LoadScene(SceneName.SCENE_BATTLE.ToString().ToLower()).ToUniTask();
            BattleSystem.Instance.LoadRoom().Forget();
        }
    }
}