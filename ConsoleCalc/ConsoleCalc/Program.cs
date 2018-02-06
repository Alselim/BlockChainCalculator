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
            string oper;
            double x, y, res;
        case1:
            try
            {
                x = Double.Parse(args[1]);
            }
            catch
            {
                Console.Write("Введите x: ");
                try
                {
                    x = Double.Parse(Console.ReadLine());
                }
                catch { goto case1; }
            }
        case2:
            try
            {
                y = Double.Parse(args[2]);
            }
            catch
            {
                Console.Write("Введите y: ");
                try
                {
                    y = Double.Parse(Console.ReadLine());
                }
                catch { goto case2; }
            }
            try
            {
                oper = Convert.ToString(args[0]);
                goto case3;
            }
            catch
            {
                Console.WriteLine("Введите необходимое действие:\nsum - для суммирования\nsub - для вычитания\nmul - для умножения\ndiv - для деления\ndeg - для возведения в степень.");
                oper = Console.ReadLine();
                goto case3;
            }
        case3:
            if (oper == "sum")
            {
                res = x + y;
                Console.WriteLine($"Sum ({x}, {y}) = {res}");
            }
            else if (oper == "sub")
            {
                res = x - y;
                Console.WriteLine($"sub ({x}, {y}) = {res}");
            }
            else if (oper == "mul")
            {
                res = x * y;
                Console.WriteLine($"mul ({x}, {y}) = {res}");
            }
            else if (oper == "div")
            {
                if (y != 0)
                {
                    res = x / y;
                    Console.WriteLine($"div ({x}, {y}) = {res}");
                }
                else Console.WriteLine("y не может быть равен 0!");
            }
            else if (oper == "deg")
            {
                res = Math.Pow(x, y);
                Console.WriteLine($"deg ({x}, {y}) = {res}");
            }
            else
            {
                Console.WriteLine("Введите необходимое действие:\nsum - для суммирования\nsub - для вычитания\nmul - для умножения\ndiv - для деления\ndeg - для возведения в степень.");
                oper = Console.ReadLine();
                goto case3;
            };
            Console.ReadKey();
        }
    }
}
