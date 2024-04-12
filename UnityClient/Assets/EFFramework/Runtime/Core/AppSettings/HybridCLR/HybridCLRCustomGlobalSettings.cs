using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

/// <summary>
/// HybridCLRCustomGlobalSettings.
/// </summary>
[Serializable]
public class HybridCLRCustomGlobalSettings
{
    public bool Enable
    {
        get
        {
#if ENABLE_HYBRIDCLR
            return true;
#else
            return false;
#endif
        }
    }

    [Header("Auto sync with [HybridCLRGlobalSettings]")]
    [Tooltip("You should modify the file form file path [Assets/CustomHybridCLR/Settings/HybridCLRGlobalSettings.asset]")]
    public List<string> HotUpdateAssemblies = new List<string>() { "AppBase.dll","DotNet.dll","AppProto.dll","AppLogic.dll"};

    [Header("Need manual setting!")] public List<string> AOTMetaAssemblies= new List<string>() {"mscorlib.dll","System.dll","System.Core.dll" };

    /// <summary>
    /// Dll of main business logic assembly
    /// </summary>
    public string LogicMainDllName = "AppLogic.dll";

    /// <summary>
    /// 程序集文本资产打包Asset后缀名
    /// </summary>
    public string AssemblyTextAssetExtension = ".bytes";

    /// <summary>
    /// 程序集文本资产资源目录
    /// </summary>
    public string AssemblyTextAssetPath = "AssetRaw/DLL";

    /// <summary>
    /// Resources HybridCLRGlobalSettings Dir
    /// </summary>
    public string HybridCLRGlobalSettings = "Settings/HybridCLRGlobalSettings";
}