using Microsoft.EntityFrameworkCore;
using System.Data;
using Team.Repository.Interface;
using TeamDataBase.Model.TeamDbcontext;
using TeamRepository.Interface;
using TeamServices.Interfaces;

namespace TeamServices.Services
{
    public class GenericServices<Context, BaseRepo, Model>:IGenericServices<Context, BaseRepo, Model>
        where Context : DbContext
        where BaseRepo : IBaseRepository<Model>
        where Model : class
    {
        private readonly IUnitOfWork<TeamDbContext> _unitOfWork;
        private readonly BaseRepo _baseRepository;
        public GenericServices(IUnitOfWork<TeamDbContext> unitOfWork, BaseRepo baseRepo) 
           
        { 
            _unitOfWork = unitOfWork;
            _baseRepository = baseRepo;
        }

        public Model Add(Model entity)
        {
           _baseRepository.Add(entity);
            _unitOfWork.Completed();
            return entity;
        }

        public Model Delete(Model entity, int id)
        {
            if (id == 0)
                throw new Exception($"Not Exisit id={id}");
            _baseRepository.Delete(entity);
            _unitOfWork.Completed();
            return entity;
        }

        public IEnumerable<Model> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public IEnumerable<Model> GetAll(string FilterName)
        {
            if (FilterName == null)
                throw new ArgumentNullException(nameof(FilterName));
            return _baseRepository.GetAll(FilterName);
        }

        public Model GetById(int id)
        {
          return  _baseRepository.GetById(id);
        }

        public Model GetByName(string name)
        {
           return _baseRepository.GetByName(name);
        }

        public Model Update(Model entity, int id)
        {
            if(id==0)
            {
                throw new Exception($"Not Exist {id}");
            }
            _baseRepository.GetById(id);
            _baseRepository.Update(entity);
            _unitOfWork.Completed();
            return entity;  
        }
    }
}
