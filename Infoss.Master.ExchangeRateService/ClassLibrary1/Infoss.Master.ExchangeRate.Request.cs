﻿namespace Infoss.Master.ExchangeRateModel
{
    public class ExchangeRateRequest
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public DateTime ExRateDate { get; set; }
        public decimal ExRate1 { get; set; } = 0;
        public decimal ExRate2 { get; set; } = 0;
        public decimal ExRate3 { get; set; } = 0;
        public bool Deleted { get; set; }
        public int CompanyId { get; set; }
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime DeletedOn { get; set; }
        public int IdLama { get; set; }
        public string Remarks { get; set; } = string.Empty;
        public string UserBy { get; set; } = string.Empty;
    }
}