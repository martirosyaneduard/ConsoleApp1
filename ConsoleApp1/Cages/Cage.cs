using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Cages
{
    abstract class Cage
    {
        public int Length { get;protected set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public bool OpenOrCloseDoor { get;protected set; } = false;
        public void Door()
        {
            if (!OpenOrCloseDoor)
            {
                Console.WriteLine("Vandaki dure pak e");
            }
            else
            {
                Console.WriteLine("Vandaki dure bac e");
            }
        }


    }
}
