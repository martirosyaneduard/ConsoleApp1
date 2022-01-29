using ConsoleApp1.Animals;
using ConsoleApp1.Foods;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Cages
{
    internal interface ICage
    {
        List<Animal> Animals { get; set; }
        void AddAnimal(Animal animal);
        event Action FoodArived;
        public void PutFood(Food food);
        void RemoveFood(Food food);
    }
}
