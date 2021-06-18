using Dapper;
using HomeAccounting.DataSource.Contract;
using Npgsql;

namespace HomeAccounting.DataSource
{
    public class RepositoryBasePostgre : IRepository
    {
        private readonly string _connectionString = "Host=localhost; Username=postgres; Password=admin; Database=postgres";

        public void AddAccount(DbAccount account)
        {
            using (NpgsqlConnection db = new NpgsqlConnection(_connectionString))
            {
                db.Execute("INSERT INTO accounts (creationDate, title) VALUES(@CreationDate, @Title)", account);
            }
        }

        public DbAccount GetAccountById(int id)
        {
            using (NpgsqlConnection db = new NpgsqlConnection(_connectionString))
            {
                return db.QueryFirst<DbAccount>("select * from accounts where id = @id", id);
            }
        }
    }
}
