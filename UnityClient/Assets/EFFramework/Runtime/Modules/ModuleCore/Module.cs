using UnityEngine;

namespace EFFramework
{
    /// <summary>
    /// 应用框架模块抽象类。
    /// </summary>
    public abstract class Module : MonoBehaviour
    {
        /// <summary>
        /// 应用框架模块初始化。
        /// </summary>
        protected virtual void Awake()
        {
            ModuleSystem.RegisterModule(this);
        }
    }
}