using ConsoleApp1.Animals;
using ConsoleApp1.Foods;
using ConsoleApp1.ImplementStrategy_DesignPattern_;
using System;
using ConsoleApp1.Cages;

namespace ConsoleApp1
{
    public delegate void EventDelegate();
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

            MyZoo myZoo = new MyZoo("20 Myasnikyan Ave, Yerevan 0025");
            myZoo.Cages.Add(new CageOfLions(20, 10, 2));
            myZoo.Cages.Add(new CageOfMonkeys(15, 10, 5));
            myZoo.AddAnimalInCage(lion);
            myZoo.AddAnimalInCage(monkey);
            myZoo.AddAnimalInCage(new Lion(2018, 4.2, new StrategyA(), GenderAnimal.Female));
            myZoo.AddAnimalInCage(new Monkey(2017, 2.5, new StrategyB(), GenderAnimal.Male));
            
        }
    }
}
