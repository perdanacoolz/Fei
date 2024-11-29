namespace Infoss.Finance.OfficialReceiptModel
{
    public class OfficialReceiptRequest
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public int ORId { get; set; }
        public int InvoicesId { get; set; }
        public int TRId { get; set; }

        public decimal PaymentUSD { get; set; }

        public decimal PaymentIDR { get; set; }
        public string ShipmentNo { get; set; } = string.Empty;
        public int ShipmentOrderId { get; set; }
        public int IdLama { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } 
       
    }
}