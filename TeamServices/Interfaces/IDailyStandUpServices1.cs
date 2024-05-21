using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Repository.Interface;
using TeamDataBase.Model;
using TeamDataBase.Model.TeamDbcontext;
using TeamServices.Interfaces;

namespace Team.Services.Interfaces
{
    public interface IDailyStandUpServices1:IGenericServices<TeamDbContext,IDailyStandUpRepository,DailyStandUp>
    {
    }
}
