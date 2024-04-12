using UnityEditor;

public static class SettingsMenu
{
    [MenuItem("EFFramework/FrameworkSettings", priority = 100)]
    public static void OpenSettings() => SettingsService.OpenProjectSettings("EFFramework/EFFrameworkSettings");
}