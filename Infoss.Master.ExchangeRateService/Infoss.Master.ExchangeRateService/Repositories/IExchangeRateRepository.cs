namespace Infoss.Master.ExchangeRateService.Repositories
{
    public interface IExchangeRateRepository
    {
        public Task<List<ExchangeRateResponse>> Read(int pageNo, int pageSize);
        public Task<ExchangeRateResponse> Read(int id);
        public Task<string> Create(ExchangeRateRequest exchangeRate);
        public Task<string> Update(ExchangeRateRequest exchangeRate);
        public Task<string> Delete(int id, string modifiedBy);

    }
}
