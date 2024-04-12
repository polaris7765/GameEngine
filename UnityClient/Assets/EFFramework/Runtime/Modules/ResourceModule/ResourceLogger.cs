namespace EFFramework
{
    internal class ResourceLogger : YooAsset.ILogger
    {
        public void Log(string message)
        {
            EFFramework.EFLogger.Info(message);
        }

        public void Warning(string message)
        {
            EFFramework.EFLogger.Warning(message);
        }

        public void Error(string message)
        {
            EFFramework.EFLogger.Error(message);
        }

        public void Exception(System.Exception exception)
        {
            EFFramework.EFLogger.Fatal(exception.Message);
        }
    }
}