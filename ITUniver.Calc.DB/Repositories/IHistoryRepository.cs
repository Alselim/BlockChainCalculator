using ITUniver.Calc.DB.Models;
using System.Collections.Generic;

namespace ITUniver.Calc.DB.Repositories
{
    public interface IHistoryRepository
    {
        IHistoryItem Find(long id);

        void Save(IHistoryItem item);

        void Delete(long id);
        IList<IHistoryItem> GetAll();
    }
}
