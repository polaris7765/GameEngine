using UnityEngine;
using UnityEngine.UI;
using EFFramework;

namespace AppLogic
{
    [Window(UILayer.UI)]
    class UILogin : UIWindow
    {
        #region 脚本工具生成的代码
        private Text m_textTittle;
        private Text m_textUserName;
        private InputField m_inputUserName;
        private Text m_textPassword;
        private InputField m_inputPassword;
        private Button m_btnCancel;
        private Button m_btnLogin;
        protected override void ScriptGenerator()
        {
            m_textTittle = FindChildComponent<Text>("BgImage/m_textTittle");
            m_textUserName = FindChildComponent<Text>("BgImage/UserName/m_textUserName");
            m_inputUserName = FindChildComponent<InputField>("BgImage/UserName/m_inputUserName");
            m_textPassword = FindChildComponent<Text>("BgImage/Password/m_textPassword");
            m_inputPassword = FindChildComponent<InputField>("BgImage/Password/m_inputPassword");
            m_btnCancel = FindChildComponent<Button>("BgImage/Group/m_btnCancel");
            m_btnLogin = FindChildComponent<Button>("BgImage/Group/m_btnLogin");
            m_btnCancel.onClick.AddListener(OnClickCancelBtn);
            m_btnLogin.onClick.AddListener(OnClickLoginBtn);
        }
        #endregion

        #region 事件
        private void OnClickCancelBtn()
        {
            Application.Quit();
        }
        private void OnClickLoginBtn()
        {
            if (!string.IsNullOrEmpty(m_inputUserName.text) && !string.IsNullOrEmpty(m_inputPassword.text))
            {
                AppEvent.Send(UIEvent.Login, new LoginData(){ UserId = 1, UserNickname = "Ned", LoginTimes = 1, IsSucceed = true});    
            }
            else
            {
                EFLogger.Info("User name or password is null!");
            }
        }
        #endregion

    }
}