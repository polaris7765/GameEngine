namespace EFFramework
{
    public static partial class Version
    {
        /// <summary>
        /// 版本号辅助器接口。
        /// </summary>
        public interface IVersionHelper
        {
            /// <summary>
            /// 获取应用版本号。
            /// </summary>
            string AppVersion
            {
                get;
            }

            /// <summary>
            /// 获取内部应用版本号。
            /// </summary>
            string InternalAppVersion
            {
                get;
            }
        }
    }
}
