using System;
using System.Reflection;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            var calc = new Calc();

            var operations = calc.GetOperNames();

            Console.WriteLine("Калькулятор");

            if (args.Length == 0)
            {
                Console.WriteLine("Введите операцию");
                foreach (var item in operations)
                {
                    Console.WriteLine(item);
                }

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

            var result = calc.Exec(oper, new[] { a, b });
 
            Console.WriteLine($"{oper}({a},{b}) = {result}");

        }
    }
}
