using System;

namespace HomeAccounting.DataSource.Contract
{
    public class DbAccount
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
    }
}
