using UnityEditor;

[CustomEditor(typeof(AutoBindGlobalSetting))]
public class AutoBindGlobalSettingInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        serializedObject.ApplyModifiedProperties();
    }
}