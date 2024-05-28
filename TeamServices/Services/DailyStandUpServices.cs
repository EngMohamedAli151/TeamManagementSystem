using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Repository.Interface;
using Team.Services.Interfaces;
using TeamDataBase.Model;
using TeamDataBase.Model.Configration;
using TeamDataBase.Model.TeamDbcontext;
using TeamRepository.Repository;
using TeamServices.Services;

namespace Team.Services.Services
{
    public class DailyStandUpServices:GenericServices<TeamDbContext,IDailyStandUpRepository,DailyStandUp>,IDailyStandUpServices
    {
        private readonly IUnitOfWork<TeamDbContext> _unitOfWork ;
        private readonly IDailyStandUpRepository _dailyStandUpRepository ;

        public DailyStandUpServices(IUnitOfWork<TeamDbContext> unitOfWork, IDailyStandUpRepository dailyStandUpRepository)
            :base(unitOfWork,dailyStandUpRepository)
        {
            _dailyStandUpRepository = dailyStandUpRepository;
            _unitOfWork=unitOfWork;
        }

        public DailyStandUp GetByDate(string date)
        {
           return _dailyStandUpRepository.GetDate(date);
        }
    }
}
