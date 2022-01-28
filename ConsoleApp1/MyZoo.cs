using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Cages;
using ConsoleApp1.Animals;

namespace ConsoleApp1
{
    class MyZoo
    {
        public string Address { get;private set; }
        public List<Cage> Cages { get; set; }
        public MyZoo(string address)
        {
            this.Address = address;
            this.Cages = new List<Cage>();
        }
        public void AddAnimalInCage(Animal animal)
        {
            if(animal is Lion)
            {
                ((CageOfLions)Cages[0]).Lions.Add((Lion)animal);
            }
            if (animal is Monkey)
            {
                ((CageOfMonkeys)Cages[1]).Monkeys.Add((Monkey)animal);
            }
        }
    }
}
