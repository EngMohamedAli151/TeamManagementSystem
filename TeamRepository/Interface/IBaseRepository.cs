using System.Linq.Expressions;

namespace TeamRepository.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        T GetByName(string name);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> match);
        IEnumerable<T> GetAll(String FilterName);

    }
}
