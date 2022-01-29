namespace ConsoleApp1.Loger
{
    interface ILog
    {
        void Error(string message);
        void Warning(string message);
        void Info(string message);
    }
}
