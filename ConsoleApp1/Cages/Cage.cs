using ConsoleApp1.Animals;
using ConsoleApp1.Foods;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Cages
{
    public class Cage : ICage
    {
        private List<Food> _foods { get; set; } = new List<Food>();
        public List<Food> Foods => _foods;
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public event Action FoodArived;

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            animal.SetCage(this);
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
