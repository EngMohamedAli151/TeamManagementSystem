using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Repository.Interface;
using Team.Services.Interfaces;
using TeamDataBase.Model;
using TeamDataBase.Model.TeamDbcontext;
using TeamServices.Services;

namespace Team.Services.Services
{
    public class Userservices:GenericServices<TeamDbContext,IUserRepository,User>,IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork<TeamDbContext> _unitOfWork;
        public Userservices(IUnitOfWork<TeamDbContext> unitOfWork, IUserRepository userRepository)
            : base(unitOfWork, userRepository)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;


        }
    }
}
