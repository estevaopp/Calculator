using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class CalculatorOp
    {        
        public static double DoOperation(double x, double y, char option)
        {
            double result = double.NaN;
            switch (option)
            {
                case 'A':
                    result = x + y;
                    break;
                case 'S':
                    result = x - y;
                    break;
                case 'M':
                    result = x * y;
                    break;
                case 'D':
                    if (y != 0)
                    {
                        result = x / y;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
