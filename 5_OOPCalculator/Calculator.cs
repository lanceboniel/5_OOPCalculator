using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOPCalculator
{
    public abstract class Calculator
    {
        private double _number1;
        private double _number2;

        public double Number1
        {
            get { return _number1; } set { _number1 = value; }
        }
        public double Number2
        {
            get { return _number2; } set { _number2 = value; }
        }
        public abstract double Calculate();
        public virtual void DisplayOperarion()
        {
            Console.WriteLine("Performing a calculation...");
        }

        //public override void DisplayOperation() => Console.WriteLine("Adding numbers...");
    }
}
