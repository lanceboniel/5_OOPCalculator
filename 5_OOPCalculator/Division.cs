using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOPCalculator
{
    internal class Division : Calculator
    {
        public override double Calculate()
        {
            if (Number2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return Number1 / Number2;
            Console.WriteLine("Dividing numbers...");
        }

           // Console.WriteLine("Dividing numbers...");
        
    }
}
