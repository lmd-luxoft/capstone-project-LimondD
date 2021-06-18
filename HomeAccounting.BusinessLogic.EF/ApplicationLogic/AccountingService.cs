using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.BusinessLogic.Contract.Dto;
using HomeAccounting.BusinessLogic.EF.Domain;
using System;
using System.Linq;

namespace HomeAccounting.BusinessLogic.EF.ApplicationLogic
{
    public class AccountingService : IAccountingService
    {
        private readonly DomainContext _ctx;

        public AccountingService(DomainContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateAccount(AccountModel account)
        {
            switch(account.Type)
            {
                case AccountType.Simple:
                    CreateSimpleAccount(account);
                    break;
                case AccountType.Cash:
                    CreateCashAccount(account);
                    break;
                case AccountType.Deposit:
                    CreateDepositAccount(account);
                    break;
                case AccountType.Property:
                    CreatePropertyAccount(account);
                    break;
                default:
                    throw new ArgumentException("Not implement type account");
            }

            _ctx.SaveChanges();
        }

        private void CreatePropertyAccount(AccountModel account)
        {
            Property property = new Property()
            {
                Balance = account.Amount,
                CreationDate = DateTime.Now,
                Location = "Moscow",
                Title = account.Title,
                Type = (PropertyType)account.Params[0],
                BasePrice = 500000.00m
            };

            _ctx.Add(property);
        }

        private void CreateDepositAccount(AccountModel account)
        {
            Bank bank = _ctx.Banks.Where(p => p.BIK == account.Params[0].ToString()).FirstOrDefault();
            if (bank == null)
            {
                throw new ArgumentException("No bank with BIK");
            }

            Deposit deposit = new Deposit()
            {
                Balance = account.Amount,
                CreationDate = DateTime.Now,
                Title = account.Title,
                Bank = bank,
                Percent = (decimal)account.Params[1],
            };

            _ctx.Add(deposit);
        }

        private void CreateCashAccount(AccountModel account)
        {
            Cash cach = new Cash()
            {
                Balance = account.Amount,
                Banknotes = 50,
                CreationDate = DateTime.Now,
                Monets = 100,
                Title = account.Title
            };

            _ctx.Add(cach);
        }

        private void CreateSimpleAccount(AccountModel account)
        {
            Domain.Account accountEntity = new Domain.Account()
            {
                Balance = account.Amount,
                CreationDate = DateTime.Now,
                Title = account.Title
            };

            _ctx.Add(accountEntity);
        }
    }
}
