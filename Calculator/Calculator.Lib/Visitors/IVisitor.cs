using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Lib.Visitors
{
    public interface IVisitor
    {
        void Visit(Calculator calculator);
    }
}