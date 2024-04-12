using UnityEngine;

namespace EFFramework.Localization
{

    public class AutoChangeCultureInfo : MonoBehaviour
    {
        public void Start()
        {
            LocalizationManager.EnableChangingCultureInfo(true);
        }
    }
}