namespace EFFramework
{
    /// <summary>
    /// 版本号类。
    /// </summary>
    public static partial class Version
    {
        private const string FrameworkVersionString = "2024.04.10";

        private static IVersionHelper s_VersionHelper = null;

        /// <summary>
        /// 获取应用框架版本号。
        /// </summary>
        public static string FrameworkVersion => FrameworkVersionString;

        /// <summary>
        /// 获取应用版本号。
        /// </summary>
        public static string AppVersion
        {
            get
            {
                if (s_VersionHelper == null)
                {
                    return string.Empty;
                }

                return s_VersionHelper.AppVersion;
            }
        }

        /// <summary>
        /// 获取内部应用版本号。
        /// </summary>
        public static string InternalAppVersion
        {
            get
            {
                if (s_VersionHelper == null)
                {
                    return string.Empty;
                }

                return s_VersionHelper.InternalAppVersion;
            }
        }

        /// <summary>
        /// 设置版本号辅助器。
        /// </summary>
        /// <param name="versionHelper">要设置的版本号辅助器。</param>
        public static void SetVersionHelper(IVersionHelper versionHelper)
        {
            s_VersionHelper = versionHelper;
        }
    }
}
