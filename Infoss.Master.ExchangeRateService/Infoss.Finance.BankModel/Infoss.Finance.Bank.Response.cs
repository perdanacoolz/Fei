namespace Infoss.Finance.BankModel
{
    public class BankResponse
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public int ORId { get; set; }
        public int InvoicesId { get; set; }
        public string BankCode { get; set; } = string.Empty;
        public string AmountCrr { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;

        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }

        public bool StatusDueDate { get; set; }

        public int AccountId { get; set; }

        public int IdLama { get; set; }

        public string ModifiedBy { get; set; } = string.Empty;

        public DateTime ModifiedOn { get; set; }

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; }

    }
}