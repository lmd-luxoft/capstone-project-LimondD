using HomeAccounting.BusinessLogic.Contract.Dto;

namespace HomeAccounting.BusinessLogic.Contract
{
    public interface IAccountingService
    {
        void CreateAccount(AccountModel account);
    }
}
