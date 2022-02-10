using System;

namespace ConsoleApp1.Events
{
    public class MyEventArgs : EventArgs
    {
        public DateTime DateTime { get; }
        public MyEventArgs(DateTime dateTime)
        {
            this.DateTime = dateTime;
        }
    }
}
