using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Lib
{
    public class BigCaretaker : IVisitor
    {
        private SmallCaretaker _smallCaretaker;
        public BigCaretaker(SmallCaretaker smallCaretaker)
        {
            _smallCaretaker = smallCaretaker;
        }

        public void Visit(Lion animal)
        {
            if(animal.Hunger > 20)
            {
                int piecesOfMeat = (int)(animal.Hunger * animal.Weight / 2000);
                if (piecesOfMeat != 0)
                {
                    animal.Hunger -= (int)Math.Round(piecesOfMeat * 2000 / animal.Weight);
                    Console.WriteLine($"{animal.Name} the {animal.Type} was hungry and was feed {piecesOfMeat} pieces of 2 kg {animal.Food} by big caretaker. Its hungerlevel is now {animal.Hunger}.");
                }
                else
                {
                    Console.WriteLine($"{animal.Name} the {animal.Type} was hungry but not hungry enough for 2 kg {animal.Food}.");
                    animal.accept(_smallCaretaker);
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
                int amountOfFish = (int)(animal.Hunger * animal.Weight / 300);
                if (amountOfFish  != 0)
                {
                    animal.Hunger -= (int)Math.Round(amountOfFish * 300 / animal.Weight);
                    Console.WriteLine($"{animal.Name} the {animal.Type} was hungry and was feed {amountOfFish} 300 g {animal.Food} by big caretaker. Its hungerlevel is now {animal.Hunger}.");
                }
                else
                {
                    Console.WriteLine($"{animal.Name} the {animal.Type} was hungry but not hungry enough for a 300 g {animal.Food}.");
                    animal.accept(_smallCaretaker);
                }
            }
            else
            {
                Console.WriteLine($"{animal.Name} the {animal.Type} was not hungry. Its hungerlevel is {animal.Hunger}.");
            }
        }
    }
}