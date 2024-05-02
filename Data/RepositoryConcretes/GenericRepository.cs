using Core.RepositoryAbstracts;
using Data.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConcretes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        AppDbContext _dbContext;
        public GenericRepository()
        {
            _dbContext = new AppDbContext();
        }
        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }
        public int Commit()
        {
            return _dbContext.SaveChanges();
        }
        public T Get(Func<T, bool>? predicate, params string[] includes)
        {

            var entity = _dbContext.Set<T>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entity = entity.Include(include);
                }
            }
            return predicate == null ?
               _dbContext.Set<T>().FirstOrDefault() :
               _dbContext.Set<T>().FirstOrDefault(predicate);
        }
        public List<T> GetAll(Func<T, bool>? predicate, params string[] includes)
        {
            var entity = _dbContext.Set<T>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entity = entity.Include(include);
                }
            }

            return predicate == null ?
                   entity.ToList() :
                   entity.Where(predicate).ToList();
        }
    }
}
