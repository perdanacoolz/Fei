namespace Infoss.Master.ExchangeRateService.Repositories
{
    public interface IOfficialReceiptRepository
    {
        public Task<List<OfficialReceiptResponse>> Read(int pageNo, int pageSize);
        public Task<OfficialReceiptResponse> Read(int id);
        public Task<string> Create(OfficialReceiptRequest officialReceipt);
        public Task<string> Update(OfficialReceiptRequest officialReceipt);
        public Task<string> Delete(int id, string modifiedBy);

    }
}
