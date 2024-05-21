using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamDataBase.Model.TeamDbcontext;
using TeamRepository.Interface;

namespace TeamRepository.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly TeamDbContext _context;
        public BaseRepository(TeamDbContext context) 
        {
            _context = context;
        }
        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            return _context .Set<T>().ToList();
        }

        public IEnumerable<T> GetAll(string FilterName)
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            var Id = _context.Set<T>().Find(id);
            return Id;
        }

        public T GetByName(string name)
        {
            var Name= _context.Set<T>().Find(name);
            return Name;
        }

        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
