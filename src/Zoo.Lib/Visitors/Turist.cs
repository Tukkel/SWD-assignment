using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Lib
{
    public class Turist : IVisitor
    {
        public void Visit(Lion animal)
        {
            animal.Hunger += 1;
            if(animal.Hunger > 20)
            {
                Console.WriteLine($"When visiting {animal.Name} the {animal.Type} it looked hungry.");
            }
            else
            {
                Console.WriteLine($"When visiting {animal.Name} the {animal.Type} it looked happy.");
            }
        }

        public void Visit(Penguin animal)
        {
            animal.Hunger += 1;
            if(animal.Hunger > 20)
            {
                Console.WriteLine($"When visiting {animal.Name} the {animal.Type} it looked hungry.");
            }
            else
            {
                Console.WriteLine($"When visiting {animal.Name} the {animal.Type} it looked happy.");
            }
        }
    }
}