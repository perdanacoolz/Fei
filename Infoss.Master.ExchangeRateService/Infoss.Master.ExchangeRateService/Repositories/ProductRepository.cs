
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Infoss.Finance.BankModel;

namespace Infoss.Master.ExchangeRateService.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private string connectionString = string.Empty;

        public ProductRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("SqlConnection");
        }

        public async Task<List<Product>> Read(int pageNo, int pageSize)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", 0);
            parameters.Add("@PageNo", pageNo);
            parameters.Add("@PageSize", pageSize);

            using (var connection = new SqlConnection(connectionString))
            {
                IEnumerable<Product> bank = await connection.QueryAsync<Product>("master.SP_Product_Read", parameters, commandType: CommandType.StoredProcedure);
                return bank.ToList();
            }
        }

        public async Task<Product> Read(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            parameters.Add("@PageNo", 0);
            parameters.Add("@PageSize", 0);

            using (var connection = new SqlConnection(connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<Product>("master.SP_Product_Read", parameters, commandType: CommandType.StoredProcedure);
            }
        }


        public async Task<string> Create(Product product)
        {
            try
            {
                var parameters = new DynamicParameters();
                
                parameters.Add("@nama_barang", product.nama_barang);
                parameters.Add("@@kode_barang", product.kode_barang);
                parameters.Add("@@jumlah_barang", product.jumlah_barang);
                parameters.Add("@@tanggal", product.tanggal);
                parameters.Add("@RowStatus", product.RowStatus);
                using (var connection = new SqlConnection(connectionString))
                {
                    var affectedRows = await connection.ExecuteAsync("master.SP_Product_Create", parameters, commandType: CommandType.StoredProcedure);
                    return "Affected Rows: " + affectedRows.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> Update(Product product)
        {
            try
            {

                using (var connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", product.Id);
                    parameters.Add("@nama_barang", product.nama_barang);
                    parameters.Add("@@kode_barang", product.kode_barang);
                    parameters.Add("@@jumlah_barang", product.jumlah_barang);
                    parameters.Add("@@tanggal", product.tanggal);
                    parameters.Add("@RowStatus", product.RowStatus);
                    var affectedRows = await connection.ExecuteAsync("master.SP_Product_Update", parameters, commandType: CommandType.StoredProcedure);
                    return "Affected Rows: " + affectedRows.ToString();
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> Delete(int id)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Id", id);

                    var affectedRows = await connection.ExecuteAsync("officialreceipt.SP_Product_Delete", parameters, commandType: CommandType.StoredProcedure);
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
