using ConsoleApp1.AnimalProperties;
using ConsoleApp1.Foods;
using ConsoleApp1.ImplementStrategy_DesignPattern_;
using Serilog;
using System;
using System.Collections.Generic;
using System.Timers;

namespace ConsoleApp1.Animals
{
    class Lion : Animal, IWalk, IRun
    {
        public Lion(GenderAnimal gender) : base("Lion", gender)
        {

        }
        public Lion(int year, int currentws, IStrategy strategy, GenderAnimal gender) : base("Lion", gender)
        {
            Strategy = strategy;


            Timer = new Timer(20000);
            Timer.Elapsed += _timer_Elapsed;

            Foods = new List<Food>();
            Foods.Add(new Meat());

            this.DateOfBirth = year;
            this.MaxWeightStomach = HowMaxStomach();
            this.CurrentWeightStomach = currentws;
        }
        ~Lion()
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
            if (CurrentWeightStomach <= -30)
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
                    return 25;
                case 2016:
                case 2017:
                    return 20;
                case 2018:
                case 2019:
                    return 15;
                case 2020:
                case 2021:
                    return 5;
                default:
                    return 30;
            }
        }

        public void Run()
        {
            Console.WriteLine($"{Name} is runing!");
        }
    }
}
