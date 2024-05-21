﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team.Repository.Interface;
using TeamDataBase.Model;
using TeamDataBase.Model.TeamDbcontext;
using TeamRepository.Interface;

namespace TeamRepository.Repository
{
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
        private readonly TeamDbContext _context;
        public UserRepository(TeamDbContext context) : base(context)
        {
            
        }
    }
}
