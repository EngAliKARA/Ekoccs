using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EkoCcs.Data.Repositories
{
    public interface IEkoccsDAO <T,V> where T : new ()
                                      where V : struct
    {
        T Insert(T t);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetFilterList(string fieldname, V v);
        T GetObjectById(V v);
        void Update(T t);
        void Delete(V v);
    }
}
