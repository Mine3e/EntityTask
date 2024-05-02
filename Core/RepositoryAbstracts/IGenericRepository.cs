using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryAbstracts
{
    public interface IGenericRepository<T> where T: class, new ()
    {
        void Add(T entity);
        void Delete(T entity);
        int Commit();
        List<T> GetAll(Func<T, bool>? predicate, params string[] includes);
        T Get(Func<T, bool>? predicate, params string[] includes);
    }
}
