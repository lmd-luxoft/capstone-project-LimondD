using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.DataSource.Contract;

namespace HomeAccounting.BusinessLogic
{
    public class AccountingService : IAccounting
    {
        private readonly IRepository _repository;

        public AccountingService(IRepository repository)
        {
            _repository = repository;
        }

        public void CreateAccount(Account account)
        {
            // Business Logic
            var dto = MapFromEntityToDto(account);
            _repository.AddAccount(dto);
        }

        private static DbAccount MapFromEntityToDto(Account account)
        {
            DbAccount dto = new DbAccount();
            // mapping
            dto.Id = account.Id;
            dto.Title = account.Title;
            dto.CreationDate = account.CreationDate;

            return dto;
        }

        private static Account MapFromDtoToEntity(DbAccount dto)
        {
            Account account = new Account();
            // mapping
            account.Id = dto.Id;
            account.Title = dto.Title;
            account.CreationDate = dto.CreationDate;

            return account;
        }

        public Account GetAccountById(int id)
        {
            var account = _repository.GetAccountById(id);
            return MapFromDtoToEntity(account);
        }

        public void SaveAccount(Account account)
        {
            throw new System.NotImplementedException();
        }
    }
}
