using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Lib.Visitors
{
    public class Adder : IVisitor
    {
        public void Visit(Calculator calculator)
        {
            double result = calculator.A + calculator.B;
            Console.WriteLine($"The sum of {calculator.A} and {calculator.B} is {result}");
        }
    }
}