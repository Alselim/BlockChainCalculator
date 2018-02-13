using ITUniver.Calc.DB.Models;
using ITUniver.Calc.DB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.Calc.WinFormApp
{
    public static class MyHelper
    {
        private static IBaseRepository<HistoryItem> History =
            new BaseRepository<HistoryItem>("History");

        private static IBaseRepository<Operation> Operations =
            new BaseRepository<Operation>();

        public static void AddToHistory(string oper, 
            double[] args, 
            double result)
        {
            var item = new HistoryItem();
            item.Args = string.Join(" ", args);
            item.Operation = 1;//oper;
            item.Result = result;
            item.ExecDate = DateTime.Now;

            History.Save(item);
        }

        public static string[] GetAll()
        {
            var opers = Operations.GetAll();

            // sum(1,3,4) = 8 / 01.01.2018
            return History.GetAll()
                .Select(hi => $"{hi.Operation}({hi.Args}) = {hi.Result} / {hi.ExecDate}")
                .ToArray();
        }

    }
}
