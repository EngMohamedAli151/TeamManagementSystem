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
    public class DailyStandUpRepository:BaseRepository<DailyStandUp>,IDailyStandUpRepository
    {
        private readonly TeamDbContext _context;
        public DailyStandUpRepository(TeamDbContext context):base(context) 
        {
            _context = context;
        }

        public DailyStandUp GetDate(string date)
        {
            if (_context.DailyStandUp.Any(x => x.Date == Convert.ToDateTime( date)))
            {
                return _context.DailyStandUp.First(x => x.Date == Convert.ToDateTime(date));
            }
            return null;
        }
    }
}
