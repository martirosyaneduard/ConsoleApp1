using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Animals;

namespace ConsoleApp1.Cages
{
    class CageOfLions:Cage
    {
        public List<Lion> Lions { get; set; }
        public CageOfLions()
        {
            this.Lions = new List<Lion>();
        }
        public CageOfLions(int length,int width,int height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.Lions = new List<Lion>();
        }
    }
}
