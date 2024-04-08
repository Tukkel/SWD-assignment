using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Lib
{
    public interface IVisitor
    {
        void Visit(Lion animal);
        void Visit(Penguin animal);
    }
}