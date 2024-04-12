namespace EFFramework
{
    public static partial class EFFrameworkLog
    {
        /// <summary>
        /// 应用框架日志辅助器接口。
        /// </summary>
        public interface ILogHelper
        {
            /// <summary>
            /// 记录日志。
            /// </summary>
            /// <param name="level">应用框架日志等级。</param>
            /// <param name="message">日志内容。</param>
            void Log(EFFrameworkLogLevel level, object message);
        }
    }
}
