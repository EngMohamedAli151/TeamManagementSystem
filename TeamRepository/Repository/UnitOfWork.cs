using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Repository.Interface;
using TeamDataBase.Model.TeamDbcontext;

namespace Team.Repository.Repository
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly TeamDbContext _context;
        public UnitOfWork(TeamDbContext context)
        { 
            _context = context;
        }
        public int Completed()
        {
          return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
