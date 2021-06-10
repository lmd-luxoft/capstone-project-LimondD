using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.DataSource.Contract;

namespace HomeAccounting.BusinessLogic
{
    public class AcountingService : IAccounting
    {
        private readonly IRepository _repository;

        public AcountingService(IRepository repository)
        {
            _repository = repository;
        }

        public void CreateAccount(Account account)
        {
            throw new System.NotImplementedException();
        }

        public Account GetAccountById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void SaveAccount(Account account)
        {
            throw new System.NotImplementedException();
        }
    }
}
