using System;

namespace HomeAccounting.BusinessLogic.Contract
{
    [Obsolete("Класс для корректной работы предыдущих версий приложения")]
    public class Account
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
    }
}
