using System;
using System.Linq;
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

                Console.WriteLine("Введите параметр через пробел");
                var x = Console.ReadLine();

                args = new[] { oper, x, "" };

            }

            Calc(args[0], args[1], args[2]);

            Console.ReadKey();
        }

        static void Calc(string oper, string x, string y)
        {
            var calc = new Calc();

            var args = x.Trim().Split(' ').Select(it => Convert.ToDouble(it)).ToList();

            if (!string.IsNullOrWhiteSpace(y))
            {
                args.Add(Convert.ToDouble(y));
            }

            var result = calc.Exec(oper, args.ToArray());

            Console.WriteLine($"{oper}({string.Join(",", args)}) = {result}");

        }
    }
}
