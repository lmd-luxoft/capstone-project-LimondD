using System;
using System.Collections.Generic;

namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class Operation : Entity
    {
        public DateTime ExecutionDate
        {
            get => default;
            set
            {
            }
        }

        public decimal Amount
        {
            get => default;
            set
            {
            }
        }

        public IEnumerable<Account> Accounts
        {
            get => default;
            set
            {
            }
        }
    }
}