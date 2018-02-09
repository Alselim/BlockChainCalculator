using System;

namespace ITUniver.Calc.DB.Models
{
    public class HistoryItem : IHistoryItem
    {
        public long Id { get; set; }

        public long Operation { get; set; }

        public string Args { get; set; }

        public double? Result { get; set; }

        public DateTime ExecDate { get; set; }
    }
}
