using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Lib.Visitors
{
    public class Multiplier : IVisitor
    {
        public void Visit(TwoNumbers calculator)
        {
            double result = calculator.A * calculator.B;
            Console.WriteLine($"The product of {calculator.A} and {calculator.B} is {result}");
        }

        public void Visit(ThreeNumbers calculator)
        {
            double result = calculator.A * calculator.B * calculator.C;
            Console.WriteLine($"The product of {calculator.A}, {calculator.B} and {calculator.C} is {result}");
        }
    }
}