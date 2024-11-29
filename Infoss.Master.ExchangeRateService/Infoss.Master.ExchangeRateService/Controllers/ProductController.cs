using Infoss.Master.ExchangeRateService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infoss.Master.ExchangeRateService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public IConfigurationRoot Configuration { get; }

        public ProductController()
        {
            IConfiguration Configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").
                Build();

            productRepository = new ProductRepository(Configuration);
        }
 
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await productRepository.Read(id);
        }

       
        [HttpGet("{pageNo}/{pageSize}")]
        public async Task<IEnumerable<Product>> Get(int pageNo, int pageSize)
        {
            return await productRepository.Read(pageNo, pageSize);
        }
         
        [HttpPost]
        public async Task<string> Post(Product product)
        {
            return await productRepository.Create(product);
        } 
        
        [HttpPut]
        public async Task<string> Put(Product product)
        {
            return await productRepository.Update(product);
        }

       
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return await productRepository.Delete(id);
        }

    }
}
