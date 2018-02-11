using System;

namespace ITUniver.Calc.DB.Models
{
    public interface IHistoryItem
    {
        long Id { get; set; }

        string Operation { get; set; }

        string Args { get; set; }

        double? Result { get; set; }

        DateTime ExecDate { get; set; }
    }
}
