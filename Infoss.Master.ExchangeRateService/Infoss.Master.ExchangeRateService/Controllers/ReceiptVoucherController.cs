using Infoss.Master.ExchangeRateService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Infoss.Master.ExchangeRateService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReceiptVoucherController : ControllerBase
    {
        private readonly IReceiptVoucherRepository receiptvoucherrepository;
        public IConfigurationRoot Configuration { get; }

        public ReceiptVoucherController()
        {
            IConfiguration Configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").
                Build();

            receiptvoucherrepository = new ReceiptVoucherRepository(Configuration);
        }

        
        [HttpGet("{id}")]
        public async Task<ReceiptVoucherResponse> Get(int id)
        {
            return await receiptvoucherrepository.Read(id);
        }

       
        [HttpGet("{pageNo}/{pageSize}")]
        public async Task<IEnumerable<ReceiptVoucherResponse>> Get(int pageNo, int pageSize)
        {
            return await receiptvoucherrepository.Read(pageNo, pageSize);
        }

        
        [HttpPost]
        public async Task<string> Post(ReceiptVoucherRequest receiptvoucher)
        {
            return await receiptvoucherrepository.Create(receiptvoucher);
        }

         
        [HttpPut]
        public async Task<string> Put(ReceiptVoucherRequest receiptvoucher)
        {
            return await receiptvoucherrepository.Update(receiptvoucher);
        }

         
        [HttpDelete("{id}/{modifiedBy}")]
        public async Task<string> Delete(int id, string modifiedBy)
        {
            return await receiptvoucherrepository.Delete(id, modifiedBy);
        }

    }
}
