using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ConsoleApp1.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class MyValidationAttribute : ValidationAttribute
    {
        public int MaxLenght { get; }
        public MyValidationAttribute(int lenght)
        {
            this.MaxLenght = lenght;
        }
        public override bool IsValid(object value)
        {
            string lenght = (String)value;
            bool result = true;
            if (this.MaxLenght > 0)
            {
                result = lenght.Length > this.MaxLenght ? false : true;
            }
            return result;
        }
        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture, ErrorMessageString, name);
        }
    }
}
