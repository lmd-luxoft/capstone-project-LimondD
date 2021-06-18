namespace HomeAccounting.DataSource.Contract
{
    public interface IRepository
    {
        void AddAccount (DbAccount account);
        DbAccount GetAccountById (int id);
    }
}
