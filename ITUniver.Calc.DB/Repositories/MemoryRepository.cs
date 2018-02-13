using System;
using ITUniver.Calc.DB.Models;
using System.Collections.Generic;

namespace ITUniver.Calc.DB.Repositories
{
    public class MemoryRepository : IHistoryRepository
    {
        private IList<IHistoryItem> items = new List<IHistoryItem>();

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IHistoryItem Find(long id)
        {
            throw new NotImplementedException();
        }

        public void Save(IHistoryItem item)
        {
            items.Add(item);
        }

        public IEnumerable<IHistoryItem> GetAll()
        { return null; }
    }
}
