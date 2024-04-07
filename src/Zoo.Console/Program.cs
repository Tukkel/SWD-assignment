using System;
using Zoo.Lib;

namespace Zoo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lion = new Lion("Kim", "Lion", 130);
			var penguin = new Penguin("Pengu", "Penguin", 10);
			var Turist = new Turist();
			var SmallCaretaker = new SmallCaretaker();
			var BigCaretaker = new BigCaretaker(SmallCaretaker);
			// Check calls when they aren't hungry
			lion.accept(Turist);
			penguin.accept(Turist);
			lion.accept(BigCaretaker);
			penguin.accept(BigCaretaker);

			// Make lion hungry
			for (int i = 0; i < 22; i++)
			{
				lion.accept(Turist);
			}
			
			// Make penguin hungry
			for (int i = 0; i < 22; i++)
			{
				penguin.accept(Turist);
			}

			// Check calls when they are hungry
			lion.accept(BigCaretaker);
			penguin.accept(BigCaretaker);
        }
    }
}