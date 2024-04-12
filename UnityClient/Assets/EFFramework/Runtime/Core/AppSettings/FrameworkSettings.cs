using UnityEngine;

[CreateAssetMenu(fileName = "EFFrameworkGlobalSettings", menuName = "EFFramework/Framework Settings")]
public class FrameworkSettings : ScriptableObject
{
    [Header("Framework")] [SerializeField] private FrameworkGlobalSettings m_FrameworkGlobalSettings;

    public FrameworkGlobalSettings FrameworkGlobalSettings => m_FrameworkGlobalSettings;

    [Header("HybridCLR")] [SerializeField] private HybridCLRCustomGlobalSettings m_BybridCLRCustomGlobalSettings;

    public HybridCLRCustomGlobalSettings BybridCLRCustomGlobalSettings => m_BybridCLRCustomGlobalSettings;

    public void Set(FrameworkGlobalSettings globalSettings,HybridCLRCustomGlobalSettings hybridClrCustomGlobalSettings)
    {
        m_FrameworkGlobalSettings = globalSettings;
        m_BybridCLRCustomGlobalSettings = hybridClrCustomGlobalSettings;
    }
}