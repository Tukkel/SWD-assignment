using System;
using Calculator.Lib;
using Calculator.Lib.Visitors;

namespace Zoo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var twoNumbers = new TwoNumbers(5, 10);
            var threeNumbers = new ThreeNumbers(5, 10, 15);
			var adder = new Adder();
            var multiplier = new Multiplier();
            
			twoNumbers.accept(adder);
            threeNumbers.accept(adder);

            twoNumbers.accept(multiplier);
            threeNumbers.accept(multiplier);
        }
    }
}