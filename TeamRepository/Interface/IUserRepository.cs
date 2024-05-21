﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamDataBase.Model;
using TeamRepository.Interface;

namespace Team.Repository.Interface
{
    public interface IUserRepository:IBaseRepository<User>
    {
    }
}