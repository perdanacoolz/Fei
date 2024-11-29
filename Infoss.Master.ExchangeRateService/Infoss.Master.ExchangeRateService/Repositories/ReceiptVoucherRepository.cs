
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Infoss.Finance.BankModel;

namespace Infoss.Master.ExchangeRateService.Repositories
{
    public class ReceiptVoucherRepository : IReceiptVoucherRepository
    {
        private string connectionString = string.Empty;

        public ReceiptVoucherRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("SqlConnection2");
        }

        public async Task<List<ReceiptVoucherResponse>> Read(int pageNo, int pageSize)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", 0);
            parameters.Add("@PageNo", pageNo);
            parameters.Add("@PageSize", pageSize);

            using (var connection = new SqlConnection(connectionString))
            {
                IEnumerable<ReceiptVoucherResponse> bank = await connection.QueryAsync<ReceiptVoucherResponse>("officialreceipt.SP_ReceiptVoucher_Read", parameters, commandType: CommandType.StoredProcedure);
                return bank.ToList();
            }
        }

        public async Task<ReceiptVoucherResponse> Read(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            parameters.Add("@PageNo", 0);
            parameters.Add("@PageSize", 0);

            using (var connection = new SqlConnection(connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<ReceiptVoucherResponse>("officialreceipt.SP_ReceiptVoucher_Read", parameters, commandType: CommandType.StoredProcedure);
            }
        }


        public async Task<string> Create(ReceiptVoucherRequest officialReceipt)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@RowStatus", officialReceipt.RowStatus);
                // parameters.Add("@Id", officialReceipt.Id);
                parameters.Add("@Code", officialReceipt.Code);
                parameters.Add("@ORId", officialReceipt.ORId);
                parameters.Add("@InvoicesId", officialReceipt.InvoicesId);
                parameters.Add("@ReceiptId", officialReceipt.ReceiptId);
                parameters.Add("@RVDetailId", officialReceipt.RVDetailId);
                parameters.Add("@PaymentUSD", officialReceipt.PaymentUSD);
                parameters.Add("@PaymentIDR", officialReceipt.PaymentIDR);
                parameters.Add("@IdLama", officialReceipt.IdLama);
                parameters.Add("@ModifiedBy", officialReceipt.ModifiedBy);
                parameters.Add("@CreatedBy", officialReceipt.CreatedBy);


                using (var connection = new SqlConnection(connectionString))
                {
                    var affectedRows = await connection.ExecuteAsync("officialreceipt.SP_ReceiptVoucher_Create", parameters, commandType: CommandType.StoredProcedure);
                    return "Affected Rows: " + affectedRows.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> Update(ReceiptVoucherRequest officialReceipt)
        {
            try
            {

                using (var connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@RowStatus", officialReceipt.RowStatus);
                    parameters.Add("@Id", officialReceipt.Id);
                    parameters.Add("@ORId", officialReceipt.ORId);
                    parameters.Add("@InvoicesId", officialReceipt.InvoicesId);
                    parameters.Add("@ReceiptId", officialReceipt.ReceiptId);
                    parameters.Add("@RVDetailId", officialReceipt.RVDetailId);
                    parameters.Add("@PaymentUSD", officialReceipt.PaymentUSD);
                    parameters.Add("@PaymentIDR", officialReceipt.PaymentIDR);
                    parameters.Add("@IdLama", officialReceipt.IdLama);
                    parameters.Add("@ModifiedBy", officialReceipt.ModifiedBy);
                    parameters.Add("@CreatedBy", officialReceipt.CreatedBy);

                    var affectedRows = await connection.ExecuteAsync("officialreceipt.SP_ReceiptVoucher_Update", parameters, commandType: CommandType.StoredProcedure);
                    return "Affected Rows: " + affectedRows.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> Delete(int id, string modifiedBy)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", id);
                    parameters.Add("@ModifiedBy", modifiedBy);

                    var affectedRows = await connection.ExecuteAsync("officialreceipt.SP_ReceiptVoucher_Delete", parameters, commandType: CommandType.StoredProcedure);
                    return "Affected Rows: " + affectedRows.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
