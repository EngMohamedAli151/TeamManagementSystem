using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Repository.Interface;
using TeamDataBase.Model;
using TeamDataBase.Model.TeamDbcontext;
using TeamRepository.Repository;

namespace Team.Repository.Repository
{
    public class DailyStandUpRepositorycs:BaseRepository<DailyStandUp>,IDailyStandUpRepository
    {
        private readonly TeamDbContext _context;
        public DailyStandUpRepositorycs(TeamDbContext context):base(context) 
        {
            
        }
    }
}
