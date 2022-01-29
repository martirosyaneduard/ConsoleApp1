using ConsoleApp1.Animals;
using ConsoleApp1.Cages;
using ConsoleApp1.Foods;
using ConsoleApp1.ImplementStrategy_DesignPattern_;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Go();
            Console.ReadKey();
        }
        public static void Go()
        {
            CreateLeonsCage(new Cage());
        }

        private static void CreateLeonsCage(ICage cage)
        {
            Animal lion = new Lion(2016, 5, new StrategyA(), GenderAnimal.Male);
            cage.AddAnimal(lion);
            cage.PutFood(new Meat(25));
        }
    }
}
