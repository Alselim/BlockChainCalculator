using ITUniver.Calc.DB.Repositories;
using System;

namespace ITUniver.Calc.DB.Models
{
    public interface IHistoryItem : IEntity
    {
        long Operation { get; set; }

        string Args { get; set; }

        double? Result { get; set; }

        DateTime ExecDate { get; set; }
    }
}
