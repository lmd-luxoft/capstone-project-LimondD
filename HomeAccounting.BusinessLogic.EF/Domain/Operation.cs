using System;
using System.Collections.Generic;

namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class Operation
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

        public IEnumerable<Account> Account
        {
            get => default;
            set
            {
            }
        }
    }
}