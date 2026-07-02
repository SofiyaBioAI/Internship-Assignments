using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderApp
{
    public class RemainderCalculator
    {
        public int CalculateWithArithmetic(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Divisor cannot be zero.");
            }

            int quotient = dividend / divisor;
            return dividend - (divisor * quotient);
        }
    }
}