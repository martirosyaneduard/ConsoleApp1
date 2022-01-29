using ConsoleApp1.Cages;
using ConsoleApp1.Foods;
using ConsoleApp1.ImplementStrategy_DesignPattern_;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace ConsoleApp1.Animals
{
    public abstract class Animal
    {
        protected IStrategy Strategy;
        protected Timer Timer { get; set; }
        private Cage _animalCage;
        public GenderAnimal Gender { get; }
        protected List<Food> Foods { get; set; }
        private int _maxWeightStomach;
        private double _currentWeightStomach;
        protected ILogger log = new LoggerConfiguration().MinimumLevel.Information().WriteTo.Console().WriteTo.File("log.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true).CreateLogger();


        public Animal(string name, GenderAnimal gender)
        {
            Name = name;
            this.Gender = gender;
        }

        public void SetCage(Cage cage)
        {
            _animalCage = cage;
            _animalCage.FoodArived += _animalCage_FoodArived;
        }

        private void _animalCage_FoodArived()
        {
            var lfood = _animalCage.Foods.FirstOrDefault(f => CanEatOrNot(f));
            if (lfood == null)
                return;
                _animalCage.RemoveFood(lfood);
                Eat(lfood);         
        }

        public string Name { get; set; }
        protected int MaxWeightStomach
        {
            get { return _maxWeightStomach; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Stamoqse taroxutyune chi karox linel 0 ic cacr!");
                }
                _maxWeightStomach = value;
            }
        }
        protected double CurrentWeightStomach
        {
            get { return _currentWeightStomach; }
            set
            {
                if (value > MaxWeightStomach)
                {
                    throw new Exception("Stamoqsi taroxutyune chi karox shat liel Maximumic");
                }
                _currentWeightStomach = value;
            }
        }

        private int dateOfBirth;

        protected int DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (value > DateTime.Now.Year)
                {
                    throw new Exception($"Kendanu cnvac tive chi karox mec linel {DateTime.Now.Year} ic");
                }
                dateOfBirth = value;
            }
        }
        public abstract void Voice();
        public virtual ValidationType Eat(Food food)
        {
            if (AliveOrNot())
            {
                log.Information($"Duq porcum eq kerakrel satkac {Name} in");
                return ValidationType.ObjectIsDie;
            }
            if (!CanEatOrNot(food))
            {
                Console.WriteLine($"{Name} utum e miayn {Foods.ToString()}");
                return ValidationType.InvalidType;
            }
            if (IsValid())
            {
                return ValidationType.IsDontHungry;
            }
            if (CurrentWeightStomach < 0)
            {
                CurrentWeightStomach = 0;
            }
            if (food.Weight + CurrentWeightStomach >= MaxWeightStomach)
            {

                CurrentWeightStomach = MaxWeightStomach;
            }
            else
            {
                CurrentWeightStomach += food.Weight;
            }
            return ValidationType.Access;
        }
        protected virtual bool CanEatOrNot(Food food)
        {
            foreach (Food item in Foods)
            {
                if (food.GetType() == item.GetType())
                {
                    Console.WriteLine($"{Name} can eat {item}");
                    return true;
                }
            }
            return false;
        }
        protected bool IsValid()
        {
            if (CurrentWeightStomach == MaxWeightStomach)
            {
                Console.WriteLine($"{Name} kusht e");
                return true;
            }
            return false;
        }
        public virtual bool AliveOrNot()
        {
            if (CurrentWeightStomach < 0)
            {
                Console.WriteLine($"{Name} is die");
                return true;
            }
            return false;
        }
    }
}
