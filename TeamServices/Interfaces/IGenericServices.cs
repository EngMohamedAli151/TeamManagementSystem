using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamServices.Interfaces
{
    public interface IGenericServices<Context, BaseRepo, Model>
    {
        Model GetById(int id);
        Model GetByName(string name);
        Model Add(Model entity);
        Model Update(Model entity,int id);
        Model Delete(Model entity,int id);
        IEnumerable<Model> GetAll();
        IEnumerable<Model> GetAll(String FilterName);
    }
}
