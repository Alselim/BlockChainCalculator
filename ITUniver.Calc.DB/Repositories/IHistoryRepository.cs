using ITUniver.Calc.DB.Models;
using System;

namespace ITUniver.Calc.DB.Repositories
{
    public interface IHistoryRepository
    {
        IHistoryItem Find(long id);

        void Save(IHistoryItem item);

        void Delete(long id);
    }
}
