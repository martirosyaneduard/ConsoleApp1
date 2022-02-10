using ConsoleApp1.Animals;
using ConsoleApp1.Events;
using ConsoleApp1.Foods;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Cages
{
    internal interface ICage
    {
        List<Animal> Animals { get; set; }
        ValidationType AddAnimal(Animal animal);
        event EventHandler<MyEventArgs> FoodArived;
        public void PutFood(Food food);
        void RemoveFood(Food food);
    }
}
