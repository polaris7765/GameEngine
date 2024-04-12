using System;

namespace EFFramework
{
    [Serializable]
    public class LoadAssetObject
    {
        public ISetAssetObject AssetObject { get; }
        public UnityEngine.Object AssetTarget { get; }
#if UNITY_EDITOR
        public bool IsSelect { get; set; }
#endif
        public LoadAssetObject(ISetAssetObject obj, UnityEngine.Object assetTarget)
        {
            AssetObject = obj;
            AssetTarget = assetTarget;
        }
    }
}