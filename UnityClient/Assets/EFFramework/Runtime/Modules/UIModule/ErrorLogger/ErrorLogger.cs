using System;
using UnityEngine;

namespace EFFramework
{
    public class ErrorLogger:IDisposable
    {
        public ErrorLogger()
        {
            Application.logMessageReceived += LogHandler;
        }

        public void Dispose()
        {
            Application.logMessageReceived -= LogHandler;
        }

        private void LogHandler(string condition, string stacktrace, LogType type)
        {
            if (type == LogType.Exception)
            {
                string des = $"客户端报错, \n#内容#：---{condition} \n#位置#：---{stacktrace}";
                AppModule.UI.ShowUIAsync<LogUI>(des);
            }
        }
    }
}