﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories
{
    /// <summary>
    /// Account repository.
    /// </summary>
    /// <seealso cref="IAccountRepository"/>
    public class AccountRepository: IAccountRepository
    {
        public Account Add(Account account, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Account Get(long personId)
        {
            throw new NotImplementedException();
        }

        public Account Edit(Account account, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void Remove(long accountId, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
