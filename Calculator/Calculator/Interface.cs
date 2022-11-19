using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Interface
    {
        public static void CalculatorInterface()
        {
            char option;
            double x;
            double y;
            double? result;

            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("\tS - Subtract");
            Console.WriteLine("\tM - Multiply");
            Console.WriteLine("\tD - Divide");
            Console.WriteLine("\tE - Exit");
            Console.WriteLine("Your Option?");

            option = Console.ReadLine()[0];

            Console.WriteLine();

            Console.Write("Type a number, and then press Enter: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Type another number, and then press Enter: ");
            y = Convert.ToDouble(Console.ReadLine());


            result = CalculatorOp.DoOperation(x, y, option);
        }

    }
}
