namespace Infoss.Master.ExchangeRateModel
{
    public class ExchangeRateResponse
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public DateTime ExRateDate { get; set; }
        public string ExRate1 { get; set; } = string.Empty;
        public string ExRate2 { get; set; } = string.Empty;
        public string ExRate3 { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public int IdLama { get; set; }
        public string Remarks { get; set; } = string.Empty;
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime DeletedOn { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } 

    }
}