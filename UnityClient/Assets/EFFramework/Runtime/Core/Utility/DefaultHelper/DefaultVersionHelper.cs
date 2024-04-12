using UnityEngine;

namespace EFFramework
{
    /// <summary>
    /// 默认版本号辅助器。
    /// </summary>
    public class DefaultVersionHelper : Version.IVersionHelper
    {
        /// <summary>
        /// 获取应用版本号。
        /// </summary>
        public string AppVersion => Application.version;

        /// <summary>
        /// 获取内部应用版本号。
        /// </summary>
        public string InternalAppVersion => string.Empty;
    }
}
