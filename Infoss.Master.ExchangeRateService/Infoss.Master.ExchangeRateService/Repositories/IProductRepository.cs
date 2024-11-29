namespace Infoss.Master.ExchangeRateService.Repositories
{
    public interface IProductRepository
    {
        public Task<List<Product>> Read(int pageNo, int pageSize);
        public Task<Product> Read(int id);
        public Task<string> Create(Product product);
        public Task<string> Update(Product product);
        public Task<string> Delete(int id);

    }
}
