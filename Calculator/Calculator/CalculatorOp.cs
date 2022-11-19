using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorOp
    {
        public CalculatorOp()
        {

        }
        public static double? DoOperation(double x, double y, char option)
        {
            double? result = null;
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
                    result = null;
                    if (y != 0)
                    {
                        result = x / y;
                    }
                    break;
                default:
                    result = null;
                    break;
            }
            return result;
        }
    }
}
