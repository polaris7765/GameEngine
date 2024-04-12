using EFFramework;

namespace AppBase
{
    /// <summary>
    /// 用于检测耗时。
    /// </summary>
    public class TickWatcher
    {
        private long _startTick;

        public TickWatcher()
        {
            Refresh();
        }

        public void Refresh()
        {
            _startTick = System.DateTime.Now.Ticks;
        }

        /// <summary>
        /// 获取用时。
        /// </summary>
        /// <returns></returns>
        public float ElapseTime()
        {
            long endTick = System.DateTime.Now.Ticks;
            return (float)((endTick - _startTick) / 10000) / 1000.0f;
        }

        /// <summary>
        /// 输出用时。
        /// </summary>
        public void LogUsedTime()
        {
            EFLogger.Info($"Used Time: {this.ElapseTime()}");
        }
    }
}