﻿using ETicaret.Core.ETicaretModel;
using ETicaret.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Repository.Repository
{
    public class UserRepository : GenericRepository<User> , IUser
    {
    }
}
