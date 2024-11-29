namespace Infoss.Finance.ReceiptVoucherModel
{
    public class ReceiptVoucherResponse
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public int ORId { get; set; }
        public int InvoicesId { get; set; }

        public int ReceiptId { get; set; }
        public int RVDetailId { get; set; }

        public decimal PaymentUSD { get; set; }
        public decimal PaymentIDR { get; set; }
        public int IdLama { get; set; }
        public string ModifiedBy { get; set; } = String.Empty;
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; }

    }
}