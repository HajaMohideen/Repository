using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview
{
    public class Repository<T> : IRepository<T>
        where T : IStoreable
    {

        List<T> items = null;

        public Repository()
        {
            items = new List<T>();
        }

        public void Save(T item)
        {
            if(item.Id != null)
                items.Add(item);
        }

        public IEnumerable<T> All()
        {
            return items.AsEnumerable();
        }

        public T FindById(IComparable id)
        {            
            return items.Find(GetItemByID(id));
        }
        
        public void Delete(IComparable id)
        {            
            
            items.RemoveAll(GetItemByID(id));
        }

        private Predicate<T> GetItemByID(IComparable id)
        {
            return item => item.Id.Equals(id);
        }

    }
}
