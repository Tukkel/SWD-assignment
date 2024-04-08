using System;
using Calculator.Lib;
using Calculator.Lib.Visitors;

namespace Zoo.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator.Lib.Calculator(5, 10);
			var adder = new Adder();
			calculator.accept(adder);

			calculator.A = -5;
			calculator.accept(adder);
        }
    }
}