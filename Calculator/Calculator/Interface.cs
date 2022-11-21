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
            double result;
            char[] possibles = { 'S', 'M', 'D', 'E' };

            while (true)
            {
                do
                {
                    

                    Console.WriteLine("Escolha uma operação:");
                    Console.WriteLine("\tS - Subtract");
                    Console.WriteLine("\tM - Multiply");
                    Console.WriteLine("\tD - Divide");
                    Console.WriteLine("\tE - Exit");
                    Console.WriteLine("Your Option?");

                    option = Console.ReadLine().ToUpper()[0];

                    Console.WriteLine();
                } while (possibles.Contains(option));
                

                if (option == 'E')
                {
                    Console.WriteLine("Exit the program");
                    return;
                }

                Console.Write("Type a number, and then press Enter: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Type another number, and then press Enter: ");
                y = Convert.ToDouble(Console.ReadLine());


                result = CalculatorOp.DoOperation(x, y, option);

                if (double.IsNaN(result))
                {
                    Console.WriteLine($"This operation will result in a mathematical error.\n");
                }
            }  
        }

    }
}
