﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.Forms.Interfaces
{
    public interface IOpenAccountBankServiceForm
    {
        void Show(Client client, AccountType accountType);
    }
}
