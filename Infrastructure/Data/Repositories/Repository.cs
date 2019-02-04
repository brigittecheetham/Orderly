using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Core.Interfaces;


namespace Infrastructure.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public T Add(T t)
        {
            return _context.Set<T>().Add(t);
        }

        public void Delete(T t)
        {
            _context.Set<T>().Remove(t);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T t)
        {
            throw new System.NotImplementedException();
        }
    }

}
