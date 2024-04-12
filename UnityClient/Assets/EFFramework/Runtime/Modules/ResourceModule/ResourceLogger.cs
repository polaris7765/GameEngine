namespace EFFramework
{
    internal class ResourceLogger : YooAsset.ILogger
    {
        public void Log(string message)
        {
            EFFramework.Log.Info(message);
        }

        public void Warning(string message)
        {
            EFFramework.Log.Warning(message);
        }

        public void Error(string message)
        {
            EFFramework.Log.Error(message);
        }

        public void Exception(System.Exception exception)
        {
            EFFramework.Log.Fatal(exception.Message);
        }
    }
}