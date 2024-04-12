using EFFramework;

namespace AppLogic
{
    public class SceneEvent
    {
        public static readonly int Login = RuntimeId.ToRuntimeId("SceneEvent.Login");
        public static readonly int Theme = RuntimeId.ToRuntimeId("SceneEvent.Theme");
    }
}