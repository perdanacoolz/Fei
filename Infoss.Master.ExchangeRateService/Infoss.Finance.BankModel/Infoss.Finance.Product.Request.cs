namespace Infoss.Finance.BankModel
{
    public class Product
    {
        public int Id { get; set; }
        public string nama_barang { get; set; } = string.Empty;
        public string kode_barang { get; set; } = string.Empty;
        public int jumlah_barang { get; set; }
        public DateTime tanggal { get; set; }
        public string RowStatus { get; set; } = string.Empty;


    }
}