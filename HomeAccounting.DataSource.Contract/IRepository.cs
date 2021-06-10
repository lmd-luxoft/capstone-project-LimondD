namespace HomeAccounting.DataSource.Contract
{
    public interface IRepository
    {
        void AddAccount (DbAccount account);
        void GetAccountById (int id);
    }
}
