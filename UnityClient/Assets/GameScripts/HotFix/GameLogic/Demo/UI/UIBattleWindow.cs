﻿using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using EFFramework;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class UIBattleWindow : UIWindow
    {
        #region 脚本工具生成的代码

        private Text m_textScore;
        private GameObject m_goOverView;
        private Button m_btnRestart;
        private Button m_btnHome;

        protected override void ScriptGenerator()
        {
            m_textScore = FindChildComponent<Text>("ScoreView/m_textScore");
            m_goOverView = FindChild("m_goOverView").gameObject;
            m_btnRestart = FindChildComponent<Button>("m_goOverView/m_btnRestart");
            m_btnHome = FindChildComponent<Button>("m_goOverView/m_btnHome");
            m_btnRestart.onClick.AddListener(UniTask.UnityAction(OnClickRestartBtn));
            m_btnHome.onClick.AddListener(UniTask.UnityAction(OnClickHomeBtn));
        }

        #endregion

        protected override void RegisterEvent()
        {
            AddUIEvent<int>(ActorEventDefine.ScoreChange, OnScoreChange);
            AddUIEvent(ActorEventDefine.GameOver, OnGameOver);
        }

        protected override void OnRefresh()
        {
            m_textScore.text = "Score : 0";
            m_goOverView.SetActive(false);
        }

        #region 事件

        private async UniTaskVoid OnClickRestartBtn()
        {
            await UniTask.Yield();
            await GameModule.Scene.LoadScene("scene_battle").ToUniTask();
    
            BattleSystem.Instance.DestroyRoom();
            BattleSystem.Instance.LoadRoom().Forget();
        }

        private async UniTaskVoid OnClickHomeBtn()
        {
            await UniTask.Yield();
            // yield return YooAssets.LoadSceneAsync("scene_home");	
            // yield return UniWindow.OpenWindowAsync<UIHomeWindow>("UIHome");
            //
            // // 释放资源
            // var package = YooAssets.GetPackage("DefaultPackage");
            // package.UnloadUnusedAssets();
        }

        #endregion

        private void OnScoreChange(int currentScores)
        {
            m_textScore.text = $"Score : {currentScores}";
        }

        private void OnGameOver()
        {
            m_goOverView.SetActive(true);
        }
    }
}