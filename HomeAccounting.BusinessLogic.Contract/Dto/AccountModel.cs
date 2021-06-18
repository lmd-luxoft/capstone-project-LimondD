namespace HomeAccounting.BusinessLogic.Contract.Dto
{
    public enum AccountType
    {
        Simple,
        Deposit,
        Property,
        Cash
    }

    public class AccountModel
    {
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public AccountType Type { get; set; }
        public object[] Params { get; set; }
    }
}
