using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Lib
{
    public class Penguin : IAnimal
    {
        public string Name { get;}
        public string Type { get;}
        public string Food { get;}
        public int Hunger { get; set; }
        public double Weight { get; set; }
        public Penguin(string name, string type, double weight)
        {
            Name = name;
            Type = type;
            Weight = weight;
            Food = "Fish";
            Hunger = 0;
        }

        public void accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}