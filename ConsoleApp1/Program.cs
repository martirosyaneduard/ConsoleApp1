using ConsoleApp1.Animals;
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
            Animal lion = new Lion(2016, 5,new StrategyA(),GenderAnimal.Male);
            lion.Eat(new Meat(25));
            Monkey monkey = new Monkey(2018, 2, new StrategyB(), GenderAnimal.Female);
            monkey.Eat(new Banana(4));
        }
    }
}
