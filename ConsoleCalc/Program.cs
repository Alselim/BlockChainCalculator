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

            if (args.Length == 0)
            {
                Console.WriteLine("Введите операцию");
                string oper = Console.ReadLine();

                Console.WriteLine("Введите параметр х");
                var x = Console.ReadLine();

                Console.WriteLine("Введите параметр y");
                var y = Console.ReadLine();

                args = new[] { oper, x, y };

            }

            Calc(args[0], args[1], args[2]);

            Console.ReadKey();
        }

        static void Calc(string oper, string x, string y)
        {
            var calc = new Calc();
            var a = Convert.ToDouble(x);
            var b = Convert.ToDouble(y);
            
            double? result = null;

            switch (oper)
            {
                case "sum":
                    {
                        result = calc.Sum(a, b);
                        break;
                    }
                case "sub":
                    {
                        result = calc.Sub(a, b);
                        break;
                    }
                default:
                    break;
            }

            Console.WriteLine($"{oper}({a},{b}) = {result}");

        }
    }
}
