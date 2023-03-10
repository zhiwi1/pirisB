﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Credit.Models;

namespace Services.Credit
{
    public interface ICreditService
    {
        void Create(CreditModel credit, bool isCardNeeded);
        CreditModel Get(int id);
        IEnumerable<CreditModel> GetAll();
        PlanOfPaymentModel GetPaymentSchedule(int creditId);
        void CloseBankDay();
        void PayPercents(int id);
        void CloseCredit(int id);
    }
}
