﻿using System;
using UnityEngine;

namespace EFFramework
{
    /// <summary>
    /// 基础模块。
    /// </summary>
    [DisallowMultipleComponent]
    public sealed class RootModule : Module
    {
        private const int DefaultDpi = 96;  // default windows dpi

        private float m_GameSpeedBeforePause = 1f;

        [SerializeField]
        private Language m_EditorLanguage = Language.Unspecified;

        [SerializeField]
        private string m_TextHelperTypeName = "EFFramework.DefaultTextHelper";

        [SerializeField]
        private string m_VersionHelperTypeName = "EFFramework.DefaultVersionHelper";

        [SerializeField]
        private string m_LogHelperTypeName = "EFFramework.DefaultLogHelper";

        [SerializeField]
        private string m_JsonHelperTypeName = "EFFramework.DefaultJsonHelper";

        [SerializeField]
        private int m_FrameRate = 120;

        [SerializeField]
        private float m_GameSpeed = 1f;

        [SerializeField]
        private bool m_RunInBackground = true;

        [SerializeField]
        private bool m_NeverSleep = true;

        /// <summary>
        /// 获取或设置编辑器语言（仅编辑器内有效）。
        /// </summary>
        public Language EditorLanguage
        {
            get => m_EditorLanguage;
            set => m_EditorLanguage = value;
        }

        /// <summary>
        /// 获取或设置应用帧率。
        /// </summary>
        public int FrameRate
        {
            get => m_FrameRate;
            set => Application.targetFrameRate = m_FrameRate = value;
        }

        /// <summary>
        /// 获取或设置应用速度。
        /// </summary>
        public float GameSpeed
        {
            get => m_GameSpeed;
            set => Time.timeScale = m_GameSpeed = value >= 0f ? value : 0f;
        }

        /// <summary>
        /// 获取应用是否暂停。
        /// </summary>
        public bool IsGamePaused => m_GameSpeed <= 0f;

        /// <summary>
        /// 获取是否正常应用速度。
        /// </summary>
        public bool IsNormalGameSpeed => Math.Abs(m_GameSpeed - 1f) < 0.01f;

        /// <summary>
        /// 获取或设置是否允许后台运行。
        /// </summary>
        public bool RunInBackground
        {
            get => m_RunInBackground;
            set => Application.runInBackground = m_RunInBackground = value;
        }

        /// <summary>
        /// 获取或设置是否禁止休眠。
        /// </summary>
        public bool NeverSleep
        {
            get => m_NeverSleep;
            set
            {
                m_NeverSleep = value;
                Screen.sleepTimeout = value ? SleepTimeout.NeverSleep : SleepTimeout.SystemSetting;
            }
        }

        /// <summary>
        /// 应用框架模块初始化。
        /// </summary>
        protected override void Awake()
        {
            base.Awake();
            
            InitTextHelper();
            InitVersionHelper();
            InitLogHelper();
            Log.Info("EFFramework Version: {0}", Version.FrameworkVersion);
            Log.Info("Game Version: {0} ({1})", Version.AppVersion, Version.InternalAppVersion);
            Log.Info("Unity Version: {0}", Application.unityVersion);

            InitJsonHelper();

            Utility.Converter.ScreenDpi = Screen.dpi;
            if (Utility.Converter.ScreenDpi <= 0)
            {
                Utility.Converter.ScreenDpi = DefaultDpi;
            }
            
            Application.targetFrameRate = m_FrameRate;
            Time.timeScale = m_GameSpeed;
            Application.runInBackground = m_RunInBackground;
            Screen.sleepTimeout = m_NeverSleep ? SleepTimeout.NeverSleep : SleepTimeout.SystemSetting;

            Application.lowMemory += OnLowMemory;
            AppTime.StartFrame();
        }

        private void Update()
        {
            AppTime.StartFrame();
            ModuleImpSystem.Update(AppTime.deltaTime, AppTime.unscaledDeltaTime);
        }

        private void FixedUpdate()
        {
            AppTime.StartFrame();
        }

        private void LateUpdate()
        {
            AppTime.StartFrame();
        }

        private void OnApplicationQuit()
        {
            Application.lowMemory -= OnLowMemory;
            StopAllCoroutines();
        }

        private void OnDestroy()
        {
            ModuleImpSystem.Shutdown();
        }

        /// <summary>
        /// 暂停应用。
        /// </summary>
        public void PauseGame()
        {
            if (IsGamePaused)
            {
                return;
            }

            m_GameSpeedBeforePause = GameSpeed;
            GameSpeed = 0f;
        }

        /// <summary>
        /// 恢复应用。
        /// </summary>
        public void ResumeGame()
        {
            if (!IsGamePaused)
            {
                return;
            }

            GameSpeed = m_GameSpeedBeforePause;
        }

        /// <summary>
        /// 重置为正常应用速度。
        /// </summary>
        public void ResetNormalGameSpeed()
        {
            if (IsNormalGameSpeed)
            {
                return;
            }

            GameSpeed = 1f;
        }

        internal void Shutdown()
        {
            Destroy(gameObject);
        }

        private void InitTextHelper()
        {
            if (string.IsNullOrEmpty(m_TextHelperTypeName))
            {
                return;
            }

            Type textHelperType = Utility.Assembly.GetType(m_TextHelperTypeName);
            if (textHelperType == null)
            {
                Log.Error("Can not find text helper type '{0}'.", m_TextHelperTypeName);
                return;
            }

            Utility.Text.ITextHelper textHelper = (Utility.Text.ITextHelper)Activator.CreateInstance(textHelperType);
            if (textHelper == null)
            {
                Log.Error("Can not create text helper instance '{0}'.", m_TextHelperTypeName);
                return;
            }

            Utility.Text.SetTextHelper(textHelper);
        }

        private void InitVersionHelper()
        {
            if (string.IsNullOrEmpty(m_VersionHelperTypeName))
            {
                return;
            }

            Type versionHelperType = Utility.Assembly.GetType(m_VersionHelperTypeName);
            if (versionHelperType == null)
            {
                throw new FrameworkException(Utility.Text.Format("Can not find version helper type '{0}'.", m_VersionHelperTypeName));
            }

            Version.IVersionHelper versionHelper = (Version.IVersionHelper)Activator.CreateInstance(versionHelperType);
            if (versionHelper == null)
            {
                throw new FrameworkException(Utility.Text.Format("Can not create version helper instance '{0}'.", m_VersionHelperTypeName));
            }

            Version.SetVersionHelper(versionHelper);
        }

        private void InitLogHelper()
        {
            if (string.IsNullOrEmpty(m_LogHelperTypeName))
            {
                return;
            }

            Type logHelperType = Utility.Assembly.GetType(m_LogHelperTypeName);
            if (logHelperType == null)
            {
                throw new FrameworkException(Utility.Text.Format("Can not find log helper type '{0}'.", m_LogHelperTypeName));
            }

            EFFrameworkLog.ILogHelper logHelper = (EFFrameworkLog.ILogHelper)Activator.CreateInstance(logHelperType);
            if (logHelper == null)
            {
                throw new FrameworkException(Utility.Text.Format("Can not create log helper instance '{0}'.", m_LogHelperTypeName));
            }

            EFFrameworkLog.SetLogHelper(logHelper);
        }

        private void InitJsonHelper()
        {
            if (string.IsNullOrEmpty(m_JsonHelperTypeName))
            {
                return;
            }

            Type jsonHelperType = Utility.Assembly.GetType(m_JsonHelperTypeName);
            if (jsonHelperType == null)
            {
                Log.Error("Can not find JSON helper type '{0}'.", m_JsonHelperTypeName);
                return;
            }

            Utility.Json.IJsonHelper jsonHelper = (Utility.Json.IJsonHelper)Activator.CreateInstance(jsonHelperType);
            if (jsonHelper == null)
            {
                Log.Error("Can not create JSON helper instance '{0}'.", m_JsonHelperTypeName);
                return;
            }

            Utility.Json.SetJsonHelper(jsonHelper);
        }

        private void OnLowMemory()
        {
            Log.Warning("Low memory reported...");
            
            ObjectPoolModule objectPoolModule = ModuleSystem.GetModule<ObjectPoolModule>();
            if (objectPoolModule != null)
            {
                objectPoolModule.ReleaseAllUnused();
            }

            ResourceModule resourceModule = ModuleSystem.GetModule<ResourceModule>();
            if (resourceModule != null)
            {
                resourceModule.ForceUnloadUnusedAssets(true);
            }
        }
    }
}
