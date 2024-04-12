namespace EFFramework
{
    /// <summary>
    /// 关闭应用框架类型。
    /// </summary>
    public enum ShutdownType : byte
    {
        /// <summary>
        /// 仅关闭应用框架。
        /// </summary>
        None = 0,

        /// <summary>
        /// 关闭应用框架并重启应用。
        /// </summary>
        Restart,

        /// <summary>
        /// 关闭应用框架并退出应用。
        /// </summary>
        Quit,
    }
}
