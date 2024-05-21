using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamRepository.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        T GetByName(string name);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(String FilterName);

    }
}
