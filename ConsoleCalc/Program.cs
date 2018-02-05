using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");

            var oper = args[0];
            if (oper == "sum")
            {
                var x = Convert.ToInt32(args[1]);
                var y = Convert.ToInt32(args[2]);
                var result = x + y;
                
                Console.WriteLine($"SUM({x}, {y}) = {result}");
            }
            else
            {
                Console.WriteLine("null");
            }
            Console.ReadKey();
        }
    }
}
