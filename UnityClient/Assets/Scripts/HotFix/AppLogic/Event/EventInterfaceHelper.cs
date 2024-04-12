using System;
using EFFramework;

namespace AppLogic
{
    /// <summary>
    /// 事件接口帮助类。
    /// </summary>
    internal class EventInterfaceHelper
    {
        /// <summary>
        /// 初始化。
        /// </summary>
        public static void Init()
        {
            RegisterEventInterface_Logic.Register(AppEvent.EventMgr);
            RegisterEventInterface_UI.Register(AppEvent.EventMgr);
        }
    }
}