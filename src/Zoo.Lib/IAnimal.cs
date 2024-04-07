using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo.Lib
{
    public interface IAnimal
    {
        string Food { get; }
        public int Hunger { get; set; }
        public double Weight { get; set; }
        void accept(IVisitor visitor);
    }
}