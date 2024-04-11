using System;
using Zoo.Lib;

namespace Zoo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lion = new Lion("Kim", "Lion", 130);
			var pinguin = new Pinguin("Pingu", "Pinguin", 10);
			var Turist = new Turist();
			var SmallCaretaker = new SmallCaretaker();
			var BigCaretaker = new BigCaretaker(SmallCaretaker);
			// Check calls when they aren't hungry
			lion.accept(Turist);
			pinguin.accept(Turist);
			lion.accept(BigCaretaker);
			pinguin.accept(BigCaretaker);

			// Make lion hungry
			for (int i = 0; i < 22; i++)
			{
				lion.accept(Turist);
			}
			
			// Make penguin hungry
			for (int i = 0; i < 22; i++)
			{
				pinguin.accept(Turist);
			}

			// Check calls when they are hungry
			lion.accept(BigCaretaker);
			pinguin.accept(BigCaretaker);
        }
    }
}