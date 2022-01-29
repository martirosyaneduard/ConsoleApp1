using System;
using System.IO;

namespace ConsoleApp1.Loger
{
    class Log : ILog
    {
        private static Log _instance;
        private static object _sync = new Object();
        private static string Path { get; set; }
        private Log()
        {

        }
        public static Log Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_sync)
                    {
                        if (Instance == null)
                        {
                            _instance = new Log();
                        }
                    }
                }
                return Instance;
            }
        }
        static Log()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("Loger");
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }
        public void Error(string message)
        {
            message = $"Error -> {DateTime.Now} -> {message}";
            this.Write(message);
        }

        public void Warning(string message)
        {
            message = $"Warning -> {DateTime.Now} -> {message}";
            this.Write(message);
        }

        public void Info(string message)
        {
            message = $"Info -> {DateTime.Now} -> {message}";
            this.Write(message);
        }
        private void Write(string message)
        {
            var lnameLog = DateTime.Now.Date;
            Path = $"Loger\\{lnameLog.ToString()}.txt";
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }
            File.AppendAllText(Path, $"{message}\n");
        }
    }
}
