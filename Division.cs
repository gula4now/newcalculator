using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorCsharp
{
   public  class Division
    {
        public double Calculate(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Error: Division by zero");
            }
            return a / b;
        }
    }
}
