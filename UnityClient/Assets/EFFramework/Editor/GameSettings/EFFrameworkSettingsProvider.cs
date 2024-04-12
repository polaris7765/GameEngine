using System.IO;
using UnityEditor;
using UnityEngine.UIElements;
using System.Collections.Generic;
using UnityEngine;

public class EFFrameworkSettingsProvider : SettingsProvider
{
    const string k_SettingsPath = "Assets/EFFramework/ResRaw/Resources/EFFrameworkGlobalSettings.asset";
    private const string headerName = "EFFramework/EFFrameworkSettings";
    private SerializedObject m_CustomSettings;
 
    internal static SerializedObject GetSerializedSettings()
    {
        return new SerializedObject(SettingsUtils.GlobalSettings);
    }

    public static bool IsSettingsAvailable()
    {
        return File.Exists(k_SettingsPath);
    }

    public override void OnActivate(string searchContext, VisualElement rootElement)
    {
        base.OnActivate(searchContext, rootElement);
        m_CustomSettings = GetSerializedSettings();
    }

    public override void OnDeactivate()
    {
        base.OnDeactivate();
        SaveAssetData(k_SettingsPath);
    }
    
    void SaveAssetData(string path)
    {
        FrameworkSettings old = AssetDatabase.LoadAssetAtPath<FrameworkSettings>(k_SettingsPath);
        FrameworkSettings data = ScriptableObject.CreateInstance<FrameworkSettings>();
        data.Set(old.FrameworkGlobalSettings, old.BybridCLRCustomGlobalSettings);
        AssetDatabase.DeleteAsset(path);
        AssetDatabase.CreateAsset(data, path);              
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }


    public override void OnGUI(string searchContext)
    {
        base.OnGUI(searchContext);
        using var changeCheckScope = new EditorGUI.ChangeCheckScope();
        EditorGUILayout.PropertyField(m_CustomSettings.FindProperty("m_FrameworkGlobalSettings"));

        if (GUILayout.Button("Refresh HotUpdateAssemblies"))
        {
            SyncAssemblyContent.RefreshAssembly();
            m_CustomSettings.ApplyModifiedPropertiesWithoutUndo();
            m_CustomSettings = null;
            m_CustomSettings = GetSerializedSettings();
        }

        EditorGUILayout.PropertyField(m_CustomSettings.FindProperty("m_BybridCLRCustomGlobalSettings"));
        EditorGUILayout.Space(20);
        if (!changeCheckScope.changed)
        {
            return;
        }
        m_CustomSettings.ApplyModifiedPropertiesWithoutUndo();
    }

    public EFFrameworkSettingsProvider(string path, SettingsScope scopes, IEnumerable<string> keywords = null) : base(path, scopes, keywords)
    {
    }

    [SettingsProvider]
    private static SettingsProvider CreateSettingProvider()
    {
        if (IsSettingsAvailable())
        {
            var provider = new EFFrameworkSettingsProvider(headerName, SettingsScope.Project);
            provider.keywords = GetSearchKeywordsFromGUIContentProperties<FrameworkSettings>();
            return provider;
        }
        else
        {
            Debug.LogError($"Open EFFramework Settings error,Please Create EFFramework EFFrameworkGlobalSettings.assets File in Path EFFramework/ResRaw/Resources/");
        }

        return null;
    }
}