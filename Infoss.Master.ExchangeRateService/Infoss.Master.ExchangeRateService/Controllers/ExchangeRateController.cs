//using Infoss.Master.ExchangeRateService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Infoss.Master.ExchangeRateModel;
using Infoss.Master.ExchangeRateService.Repositories;

namespace Infoss.Master.ExchangeRateService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        private readonly IExchangeRateRepository exchangeRateRepository;
        public IConfigurationRoot Configuration { get; }

        public ExchangeRateController()
        {
            IConfiguration Configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").
                Build();

            exchangeRateRepository = new ExchangeRateRepository(Configuration);
        }

        // GET <ExchangeRateController>/5
        [HttpGet("{id}")]
        public async Task<ExchangeRateResponse> Get(int id)
        {
            return await exchangeRateRepository.Read(id);
        }

        // GET <ExchangeRateController>/1/20
        [HttpGet("{pageNo}/{pageSize}")]
        public async Task<IEnumerable<ExchangeRateResponse>> Get(int pageNo, int pageSize)
        {
            return await exchangeRateRepository.Read(pageNo, pageSize);
        }

        // POST <ExchangeRateController>
        [HttpPost]
        public async Task<string> Post(ExchangeRateRequest exchangeRate)
        {
            return await exchangeRateRepository.Create(exchangeRate);
        }

        // PUT <ExchangeRateController>
        [HttpPut]
        public async Task<string> Put(ExchangeRateRequest exchangeRate)
        {
            return await exchangeRateRepository.Update(exchangeRate);
        }

        // DELETE <ExchangeRateController>/5/Admin
        [HttpDelete("{id}/{modifiedBy}")]
        public async Task<string> Delete(int id, string modifiedBy)
        {
            return await exchangeRateRepository.Delete(id, modifiedBy);
        }

    }
}
