using ConsoleApp1.Animals;
using ConsoleApp1.Cages;
using ConsoleApp1.Foods;
using ConsoleApp1.ImplementStrategy_DesignPattern_;
using System;
using ConsoleApp1.Loger;
using ConsoleApp1.CustomAttributes;

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
            GetAttribute(typeof(Log));
        }

        private static void CreateLeonsCage(ICage cage)
        {
            Animal lion = new Lion(2016, 5, new StrategyA(), GenderAnimal.Male);
            cage.AddAnimal(lion);
            cage.PutFood(new Food(25,TypesOfFood.Meat));
        }
        public static void GetAttribute(Type type)
        {
            DeveloperAttribute lmyAttribute = (DeveloperAttribute)Attribute.GetCustomAttribute(type, typeof(DeveloperAttribute));
            if (lmyAttribute == null)
            {
                Console.WriteLine("The attribute was not found.");
            }
            else
            {
                Console.WriteLine($"{lmyAttribute.Name} is creat {type.FullName}");
                Console.WriteLine($"The level is {lmyAttribute.Level}");
                Console.WriteLine($"The Reviewed is {lmyAttribute.Reviewed}");
            }
        }
    }
}
