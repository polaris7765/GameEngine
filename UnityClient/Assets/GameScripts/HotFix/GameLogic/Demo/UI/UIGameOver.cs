using UnityEngine;
using UnityEngine.UI;
using EFFramework;
using UnityEngine.PlayerLoop;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class UIGameOver : UIWindow
    {
        #region 脚本工具生成的代码
        private GameObject m_goTop;
        private Button m_btnStart;
        private Button m_btnAbout;
        private Text m_textVersion;
        protected override void ScriptGenerator()
        {
            m_goTop = FindChild("m_goTop").gameObject;
            m_btnStart = FindChildComponent<Button>("m_goTop/m_btnStart");
            m_btnAbout = FindChildComponent<Button>("m_btnAbout");
            m_textVersion = FindChildComponent<Text>("m_textVersion");
            m_btnStart.onClick.AddListener(OnClickStartBtn);
            m_btnAbout.onClick.AddListener(OnClickAboutBtn);
        }
        #endregion

        #region 事件
        private void OnClickStartBtn()
        {
            Log.Info("OnClickStartBtn");
        }
        private void OnClickAboutBtn()
        {
            Log.Info("OnClickAboutBtn");
        }
        #endregion

        protected override void OnUpdate()
        {
            //Debug.Log("On update");
        }
    }
}
