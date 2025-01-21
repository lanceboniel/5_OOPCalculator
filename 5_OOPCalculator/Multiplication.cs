using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOPCalculator
{
    internal class Multiplication : Calculator
    {
        public override double Calculate()
        {
            return Number1 * Number2;
        }
    }
}
