﻿using SimpleTrader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Services
{
    public interface IAccountService : IDataService<Account>
    {
        Task<Account> GetByUserName(string userName);

        Task<Account> GetByEmail(string email);
    }
}
