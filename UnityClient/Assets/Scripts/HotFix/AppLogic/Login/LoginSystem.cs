using Cysharp.Threading.Tasks;
using EFFramework;
using UnityEngine;
using AudioType = EFFramework.AudioType;

namespace AppLogic
{
    public class LoginData
    {
        public int UserId;
        public string UserNickname;
        public int LoginTimes;
        public bool IsSucceed;
    }
    public class LoginSystem: BehaviourSingleton<LoginSystem>
    {
        /// <summary>
        /// 加载Login
        /// </summary>
        public async UniTaskVoid LoadLogin()
        {
            await UniTask.Yield();
            // 显示Login界面
            AppModule.UI.ShowUIAsync<UILogin>();
            AppEvent.AddEventListener<LoginData>(UIEvent.Login, OnUserLogin);
        }

        private void OnUserLogin(LoginData data)
        {
            if (data.IsSucceed)
            {
                EFLogger.Info($"Login Succeed:{data.UserId},{data.UserNickname},{data.LoginTimes}");
                AppModule.UI.CloseUI<UILogin>();
                AppEvent.Send(SceneEvent.Theme);
            }
            else
            {
                EFLogger.Info("Login failed!");
            }
            
        }
    }
}