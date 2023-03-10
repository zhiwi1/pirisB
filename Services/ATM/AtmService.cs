﻿using System.Linq;
using Services.Account;
using Services.Common.Model;
using Services.Credit.Models;
using Services.Transaction;
using Microsoft.Practices.Unity;

namespace Services.ATM
{
    public class AtmService : BaseService, IAtmService
    {
        [Dependency]
        public ITransactionService TransactionService { get; set; }

        [Dependency]
        public IAccountService AccountService { get; set; }

        public AtmService() : base()
        {
        }

        public CreditModel LoginUser(string creditCardNumber, string pin)
        {
            var credit =
                Context.Credits.FirstOrDefault(
                    e => e.CreditCardNumber == creditCardNumber && e.CreditCardPin == pin);
            return credit != null ? Mapper.Map<ORMLibrary.Credit, CreditModel>(credit) : null;
        }

        public void WithDrawMoney(int creditId, decimal amount)
        {
            var credit = Context.Credits.FirstOrDefault(e => e.Id == creditId);
            if (credit.MainAccount.Balance < amount)
            {
                throw new ServiceException("Not enough money in the account.");
            }

            TransactionService.CommitTransaction(credit.MainAccount, AccountService.GetCashDeskAccount(), amount);
            TransactionService.WithDrawCashDeskTransaction(amount);
            Context.SaveChanges();
        }

        public void TransferMoney(int creditId, string accountNumber, decimal amount)
        {
            var credit = Context.Credits.FirstOrDefault(e => e.Id == creditId);
            var account = Context.Accounts.FirstOrDefault(e => e.AccountNumber == accountNumber);
            if (credit.MainAccount.Balance < amount)
            {
                throw new ServiceException("Not enough money in the account.");
            }

            TransactionService.CommitTransaction(credit.MainAccount, account, amount);
            Context.SaveChanges();
        }
    }
}
