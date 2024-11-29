
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Infoss.Master.ExchangeRateService.Repositories
{
    public class OfficialReceiptRepository : IOfficialReceiptRepository
    {
        private string connectionString = string.Empty;

        public OfficialReceiptRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("SqlConnection2");
        }

        public async Task<List<OfficialReceiptResponse>> Read(int pageNo, int pageSize)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", 0);
            parameters.Add("@PageNo", pageNo);
            parameters.Add("@PageSize", pageSize);

            using (var connection = new SqlConnection(connectionString))
            {
                IEnumerable<OfficialReceiptResponse> country = await connection.QueryAsync<OfficialReceiptResponse>("officialreceipt.SP_TemporaryReceipt_Read", parameters, commandType: CommandType.StoredProcedure);
                return country.ToList();
            }
        }

        public async Task<OfficialReceiptResponse> Read(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            parameters.Add("@PageNo", 0);
            parameters.Add("@PageSize", 0);

            using (var connection = new SqlConnection(connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<OfficialReceiptResponse>("officialreceipt.SP_TemporaryReceipt_Read", parameters, commandType: CommandType.StoredProcedure);
            }
        }


        public async Task<string> Create(OfficialReceiptRequest officialreceipt)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@RowStatus", officialreceipt.RowStatus);
                parameters.Add("@Code", officialreceipt.Code);
                parameters.Add("@OrId", officialreceipt.ORId);
                parameters.Add("@InvoicesId", officialreceipt.InvoicesId);
                parameters.Add("@TRId", officialreceipt.TRId);
                parameters.Add("@PaymentUSD", officialreceipt.PaymentUSD);
                parameters.Add("@PaymentIDR", officialreceipt.PaymentIDR);
                parameters.Add("@Shipmentno", officialreceipt.ShipmentNo);
                parameters.Add("@ShipmentOrderId", officialreceipt.ShipmentOrderId);
                parameters.Add("@IdLama", officialreceipt.IdLama);
                parameters.Add("@ModifiedBy", officialreceipt.ModifiedBy);
                parameters.Add("@CreatedBy", officialreceipt.CreatedBy);

                using (var connection = new SqlConnection(connectionString))
                {
                    var affectedRows = await connection.ExecuteAsync("officialreceipt.SP_TemporaryReceipt_Create", parameters, commandType: CommandType.StoredProcedure);
                    return "Affected Rows: " + affectedRows.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> Update(OfficialReceiptRequest officialreceipt)
        {
            try
            {

                using (var connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@RowStatus", officialreceipt.RowStatus);
                    parameters.Add("@Id", officialreceipt.Id);
                    parameters.Add("@Code", officialreceipt.Code);
                    parameters.Add("@OrId", officialreceipt.ORId);
                    parameters.Add("@InvoicesId", officialreceipt.InvoicesId);
                    parameters.Add("@TRId", officialreceipt.TRId);
                    parameters.Add("@PaymentUSD", officialreceipt.PaymentUSD);
                    parameters.Add("@PaymentIDR", officialreceipt.PaymentIDR);
                    parameters.Add("@Shipmentno", officialreceipt.ShipmentNo);
                    parameters.Add("@ShipmentOrderId", officialreceipt.ShipmentOrderId);
                    parameters.Add("@IdLama", officialreceipt.IdLama);
                    parameters.Add("@ModifiedBy", officialreceipt.ModifiedBy);
                    parameters.Add("@CreatedBy", officialreceipt.CreatedBy);

                    var affectedRows = await connection.ExecuteAsync("officialreceipt.SP_TemporaryReceipt_Update", parameters, commandType: CommandType.StoredProcedure);
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

                    var affectedRows = await connection.ExecuteAsync("officialreceipt.SP_TemporaryReceipt_Delete", parameters, commandType: CommandType.StoredProcedure);
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
