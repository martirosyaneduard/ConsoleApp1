using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Animals;


namespace ConsoleApp1.Cages
{
    class CageOfMonkeys : Cage
    {
        public List<Monkey> Monkeys { get; set; }
        public CageOfMonkeys()
        {
            this.Monkeys = new List<Monkey>();
        }
        public CageOfMonkeys(int length, int width, int height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.Monkeys = new List<Monkey>();
        }
    }
}
