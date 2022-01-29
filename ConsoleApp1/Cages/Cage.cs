using System;
using System.Collections.Generic;
using ConsoleApp1.Animals;
using ConsoleApp1.Foods;

namespace ConsoleApp1.Cages
{
    public class Cage : ICage
    {
        public int Length { get; protected set; }
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        private List<Food> _foods { get; set; } = new List<Food>();
        public List<Food> Foods => _foods;
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public event Action FoodArived;

        public ValidationType AddAnimal(Animal animal)
        {
            if (Animals.Count >= 6)
            {
                return ValidationType.NoPlace;
            }
            if (animal is Lion)
            {
                Animals.Add(animal);
                animal.SetCage(this);
                return ValidationType.Access;
            }
            return ValidationType.InvalidType;

        }

        public void RemoveFood(Food food)
        {
            _foods.Remove(food);
        }

        public void PutFood(Food food)
        {
            _foods.Add(food);
            FoodArived?.Invoke();
        }


    }
}
