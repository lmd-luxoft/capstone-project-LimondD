using System;

namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class Account : Entity
    {
        public DateTime CreationDate { get; set; }

        public string Title { get; set; }

        public decimal Balance { get; set; }
    }
}