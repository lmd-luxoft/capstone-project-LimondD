namespace HomeAccounting.BusinessLogic.EF.Domain
{
    public class Bank : Entity
    {
        public string BIK { get; set; }

        public string CorrespondAccount { get; set; }

        public string Title { get; set; }
    }
}