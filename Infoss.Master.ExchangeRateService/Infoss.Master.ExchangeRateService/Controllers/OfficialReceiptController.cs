using Infoss.Master.ExchangeRateService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infoss.Master.ExchangeRateService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OfficialReceiptController : ControllerBase
    {
        private readonly IOfficialReceiptRepository OfficialReceiptRepository;
        public IConfigurationRoot Configuration { get; }

        public OfficialReceiptController()
        {
            IConfiguration Configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").
                Build();

            OfficialReceiptRepository = new OfficialReceiptRepository(Configuration);
        }

         
        [HttpGet("{id}")]
        public async Task<OfficialReceiptResponse> Get(int id)
        {
            return await OfficialReceiptRepository.Read(id);
        }

     
        [HttpGet("{pageNo}/{pageSize}")]
        public async Task<IEnumerable<OfficialReceiptResponse>> Get(int pageNo, int pageSize)
        {
            return await OfficialReceiptRepository.Read(pageNo, pageSize);
        }

        
        [HttpPost]
        public async Task<string> Post(OfficialReceiptRequest exchangeRate)
        {
            return await OfficialReceiptRepository.Create(exchangeRate);
        }

       
        [HttpPut]
        public async Task<string> Put(OfficialReceiptRequest exchangeRate)
        {
            return await OfficialReceiptRepository.Update(exchangeRate);
        }

      
        [HttpDelete("{id}/{modifiedBy}")]
        public async Task<string> Delete(int id, string modifiedBy)
        {
            return await OfficialReceiptRepository.Delete(id, modifiedBy);
        }

    }
}
