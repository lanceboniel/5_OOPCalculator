using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOPCalculator
{
    public class Addition : Calculator
    {
        public override double Calculate()
        {
            return Number1 + Number2;
        }
    }
}
