using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Calculator.Lib;

public interface ICalculator
{
    void accept(IVisitor visitor);
}