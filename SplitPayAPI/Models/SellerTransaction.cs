using System.ComponentModel.DataAnnotations.Schema;

namespace SplitPayAPI.Models
{
    [Table("SellersTransactions")]
    public class SellerTransaction
    {
        public int id { get; set; }
        public string amount { get; set; }
        public string order { get; set; }
        public string createdon { get; set; }
        public int seller_id { get; set; }
    }
}