﻿using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.Business
{
    public interface IUserLoginService
    {
        Task<UserAccount> GetUser(string userName, string password);
    }
}
