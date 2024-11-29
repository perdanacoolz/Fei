
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Infoss.Master.ExchangeRateService.Repositories
{
    public class ExchangeRateRepository : IExchangeRateRepository
    {
        private string connectionString = string.Empty;

        public ExchangeRateRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("SqlConnection");
        }

        public async Task<List<ExchangeRateResponse>> Read(int pageNo, int pageSize)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", 0);
            parameters.Add("@PageNo", pageNo);
            parameters.Add("@PageSize", pageSize);

            using (var connection = new SqlConnection(connectionString))
            {
                IEnumerable<ExchangeRateResponse> country = await connection.QueryAsync<ExchangeRateResponse>("SP_ExchangeRate_Read", parameters, commandType: CommandType.StoredProcedure);
                return country.ToList();
            }
        }

        public async Task<ExchangeRateResponse> Read(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            parameters.Add("@PageNo", 0);
            parameters.Add("@PageSize", 0);

            using (var connection = new SqlConnection(connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<ExchangeRateResponse>("SP_ExchangeRate_Read", parameters, commandType: CommandType.StoredProcedure);
            }
        }


        public async Task<string> Create(ExchangeRateRequest exchangerate)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@RowStatus", exchangerate.RowStatus);
               parameters.Add("@Code", exchangerate.Code);
                //parameters.Add("@ExRateDate", exchangerate.ExRateDate);
                //parameters.Add("@ExRate1", exchangerate.ExRate1);
                //parameters.Add("@ExRate2", exchangerate.ExRate2);
                //parameters.Add("@ExRate3", exchangerate.ExRate3);
                //parameters.Add("@Deleted", exchangerate.DeletedBy);
                //parameters.Add("@CompanyId", exchangerate.CompanyId);
                //parameters.Add("@DeletedOn", exchangerate.DeletedOn);
                //parameters.Add("@DeletedBy", exchangerate.DeletedBy);
                //parameters.Add("@IdLama", exchangerate.IdLama);
                //parameters.Add("@Remarks", exchangerate.Remarks);
                //parameters.Add("@CreatedBy", exchangerate.UserBy);

                using (var connection = new SqlConnection(connectionString))
                {
                    var affectedRows = await connection.ExecuteAsync("SP_ExchangeRate_Create", parameters, commandType: CommandType.StoredProcedure);
                    return "Affected Rows: " + affectedRows.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> Update(ExchangeRateRequest exchangerate)
        {
            try
            {

                using (var connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@RowStatus", exchangerate.RowStatus);
                    parameters.Add("@Id", exchangerate.Id);
                    parameters.Add("@Code", exchangerate.Code);
                    parameters.Add("@ExRateDate", exchangerate.ExRateDate);
                    parameters.Add("@ExRate1", exchangerate.ExRate1);
                    parameters.Add("@ExRate2", exchangerate.ExRate2);
                    parameters.Add("@ExRate3", exchangerate.ExRate3);
                    parameters.Add("@Deleted", exchangerate.DeletedBy);
                    parameters.Add("@CompanyId", exchangerate.CompanyId);
                    parameters.Add("@DeletedOn", exchangerate.DeletedOn);
                    parameters.Add("@DeletedBy", exchangerate.DeletedBy);
                    parameters.Add("@IdLama", exchangerate.IdLama);
                    parameters.Add("@Remarks", exchangerate.Remarks);

                    var affectedRows = await connection.ExecuteAsync("master.SP_ExchangeRate_Update", parameters, commandType: CommandType.StoredProcedure);
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

                    var affectedRows = await connection.ExecuteAsync("master.SP_ExchangeRate_Delete", parameters, commandType: CommandType.StoredProcedure);
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
