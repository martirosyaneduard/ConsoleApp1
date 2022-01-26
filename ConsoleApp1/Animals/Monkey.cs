using ConsoleApp1.AnimalProperties;
using ConsoleApp1.Foods;
using ConsoleApp1.ImplementStrategy_DesignPattern_;
using Serilog;
using System;
using System.Collections.Generic;
using System.Timers;

namespace ConsoleApp1.Animals
{
    class Monkey:Animal, IWalk, IRun,ClimbATree
    {
        public Monkey(GenderAnimal gender) :base("Monkey",gender)
        {

        }
        public Monkey(int year, int currentws, IStrategy strategy, GenderAnimal gender) : base("Monkey", gender)
        {
            Strategy = strategy;


            Timer = new Timer(15000);
            Timer.Elapsed += _timer_Elapsed;

            Foods = new List<Food>();
            Foods.Add(new Banana());

            this.DateOfBirth = year;
            this.MaxWeightStomach = HowMaxStomach();
            this.CurrentWeightStomach = currentws;
        }
        ~Monkey()
        {
            Timer.Stop();
            log.Information($"{Name} is Die");
            Log.CloseAndFlush();
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CurrentWeightStomach = Strategy.HowToAnimalHungry(CurrentWeightStomach);
        }


        protected override bool AliveOrNot()
        {
            if (CurrentWeightStomach <= -10)
            {
                Console.WriteLine($"{Name} is die");
                return true;
            }
            return false;
        }
        public override void Voice()
        {
            Console.WriteLine($"Voic {Name}");
        }

        public void Walking()
        {
            Console.WriteLine($"{Name} is walking");
        }
        private int HowMaxStomach()
        {
            switch (DateOfBirth)
            {
                case 2014:
                case 2015:
                    return 7;
                case 2016:
                case 2017:
                    return 6;
                case 2018:
                case 2019:
                    return 4;
                case 2020:
                case 2021:
                    return 2;
                case 2022:
                    return 1;
                default:
                    return 8;
            }
        }

        public void Run()
        {
            Console.WriteLine($"{Name} is runing!");
        }

        public void Climb()
        {
            Console.WriteLine("Kapike maglcum e cari vra");
        }
    }
}
