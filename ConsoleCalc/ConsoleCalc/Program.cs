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

                Console.Write("Введите числа через запятую:");
                var x = Console.ReadLine();
                var y = x.Split(',');

                Calc(oper, y);
            }
            else
            {
                string oper = args[0];
                string[] y = args[1].Split(',');
                Calc(oper, y);
            }

            Console.ReadKey();
        }

        static void Calc(string oper, string[] y)
        {
            var calc = new Calc();

            //var a = Convert.ToDouble(x);
            double[] b = new double[y.Length];

            for (int i = 0; i < y.Length; i++)
            {
                b[i] = Convert.ToDouble(y[i]);
            }
            var result = calc.Exec(oper,  b );

            Console.WriteLine($"{oper}({String.Join(", ", b)}) = {result}");

        }
    }
}