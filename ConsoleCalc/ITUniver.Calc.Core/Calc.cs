using ITUniver.Calc.Core.Interfaces;
using ITUniver.Calc.Core.Operations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ConsoleCalc
{
    public class Calc
    {
        private IList<IOperation> operations { get; set; }

        public Calc()
        {
            operations = new List<IOperation>();

            //Загружаем наши библиотеки
            LoadOperation(Assembly.GetExecutingAssembly());

            //Загружаем библиотеки сторонних разработчиков
            //var assembly = Assembly.GetExecutingAssembly();
            var extensionDir = Path.Combine(Environment.CurrentDirectory, "Extensions");
            var files = Directory.GetFiles(extensionDir, "*.dll");

            foreach (var file in files)
            {
                LoadOperation(Assembly.LoadFile(file));
            }
            var assembly = Assembly.LoadFile(files.FirstOrDefault());

        }


        private void LoadOperation(Assembly assembly)
        {
            var types = assembly.GetTypes();
            var typeofOperation = typeof(IOperation);

            foreach (var item in types.Where(t => !t.IsAbstract && !t.IsInterface))
            {
                var interfaces = item.GetInterfaces();

                var isOperation = interfaces.Any(
                    it => it == typeofOperation);

                if (isOperation)
                {
                    // создаем эксземпляр объекта
                    var obj = Activator.CreateInstance(item);
                    // пытаемся превратить его в операцию
                    var operation = obj as IOperation;
                    // если удалось
                    if (operation != null)
                    {
                        // добавляем в список операций
                        operations.Add(operation);
                    }
                }
            }

        }
        /// <summary>
        /// Получить список имен операциий
        /// </summary>
        /// <returns></returns>
        public string[] GetOperNames()
        {
            return operations.Select(it => it.Name).ToArray();
        }

        public double Exec(string oper, double[] args)
        {
            // найти операцию в списке
            var operation = operations.FirstOrDefault(o => o.Name == oper);

            // если не найдено - возвращает ошибку
            if (operation == null)
                return double.NaN;

            // если нашли
            // передаем ей аргументы и вычисляем результат
            var result = operation.Exec(args);

            // возвращаем результат
            return result;
        }

        public double Sum(double x, double y)
        {
            var oper = new SumOperation();
            var result = oper.Exec(new[] { x, y, });
            return result;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }

        public double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}