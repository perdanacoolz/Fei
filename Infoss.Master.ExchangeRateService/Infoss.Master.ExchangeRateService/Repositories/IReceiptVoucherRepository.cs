namespace Infoss.Master.ExchangeRateService.Repositories
{
    public interface IReceiptVoucherRepository
    {
        public Task<List<ReceiptVoucherResponse>> Read(int pageNo, int pageSize);
        public Task<ReceiptVoucherResponse> Read(int id);
        public Task<string> Create(ReceiptVoucherRequest receiptVoucher);
        public Task<string> Update(ReceiptVoucherRequest receiptVoucher);
        public Task<string> Delete(int id, string modifiedBy);

    }
}
