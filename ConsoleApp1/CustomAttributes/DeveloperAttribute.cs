using System;

namespace ConsoleApp1.CustomAttributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public class DeveloperAttribute : Attribute
    {
        private string _name;
        private string _level;
        private bool _reviewed;
        public DeveloperAttribute(string name, string level)
        {
            this._name = name;
            this._level = level;
            this._reviewed = false;
        }
        public virtual string Name
        {
            get { return _name; }
        }
        public virtual string Level
        {
            get { return _level; }
        }
        public virtual bool Reviewed
        {
            get { return _reviewed; }
            set { _reviewed = value; }
        }
    }
}
