using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Core.DTO;
using Team.Repository.Interface;
using TeamDataBase.Model;
using TeamDataBase.Model.TeamDbcontext;
using TeamServices.Interfaces;

namespace Team.Services.Interfaces
{
    public interface IDailyStandUpServices:IGenericServices<TeamDbContext,IDailyStandUpRepository,DailyStandUp>
    {
       DailyStandUp GetAll(DailyStandUPFilter filter );
       
    }
}
