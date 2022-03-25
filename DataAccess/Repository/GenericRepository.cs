using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T entity)
        {
            using var p = new Context();
            p.Remove(entity);
            p.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var p = new Context();
            return p.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var p = new Context();
            return p.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            using var p = new Context();
            p.Add(entity);
            p.SaveChanges();
        }

        public void Update(T entity)
        {
            using var p = new Context();
            p.Update(entity);
            p.SaveChanges();
        }
    }
}
