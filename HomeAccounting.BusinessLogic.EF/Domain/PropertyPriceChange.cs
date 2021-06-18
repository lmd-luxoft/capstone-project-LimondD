using System;

namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class PropertyPriceChange : Entity
    {
        public int Delta { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}