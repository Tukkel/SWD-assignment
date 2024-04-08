using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Lib
{
    public class SmallCaretaker : IVisitor
    {
        public void Visit(Lion animal)
        {
            if(animal.Hunger > 20)
            {
                int piecesOfMeat = (int)(animal.Hunger * animal.Weight / 200);
                if (piecesOfMeat != 0)
                {
                    animal.Hunger -= (int)Math.Round(piecesOfMeat * 200 / animal.Weight);
                    Console.WriteLine($"{animal.Name} the {animal.Type} was hungry and was feed {piecesOfMeat} pieces of 200 g {animal.Food} by small caretaker. Its hungerlevel is now {animal.Hunger}.");
                }
                else
                {
                    Console.WriteLine($"{animal.Name} the {animal.Type} was hungry but not hungry enough for 200 g {animal.Food}. Its hungerlevel is now {animal.Hunger}.");
                }
            }
            else
            {
                Console.WriteLine($"{animal.Name} the {animal.Type} was not hungry. Its hungerlevel is {animal.Hunger}.");
            }
        }

        public void Visit(Penguin animal)
        {
            if(animal.Hunger > 20)
            {
                int amountOfFish = (int)(animal.Hunger * animal.Weight / 30);
                if (amountOfFish  != 0)
                {
                    animal.Hunger -= (int)Math.Round(amountOfFish * 30 / animal.Weight);
                    Console.WriteLine($"{animal.Name} the {animal.Type} was hungry and was feed {amountOfFish} 30 g {animal.Food} by small caretaker. Its hungerlevel is now {animal.Hunger}.");
                }
                else
                {
                    Console.WriteLine($"{animal.Name} the {animal.Type} was hungry but not hungry enough for a 30 g {animal.Food}. Its hungerlevel is now {animal.Hunger}.");
                }
            }
            else
            {
                Console.WriteLine($"{animal.Name} the {animal.Type} was not hungry. Its hungerlevel is {animal.Hunger}.");
            }
        }
    }
}