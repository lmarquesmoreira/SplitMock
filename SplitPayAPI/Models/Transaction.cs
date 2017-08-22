using System.ComponentModel.DataAnnotations.Schema;

namespace SplitPayAPI.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        public int id { get; set; }
        public string amount { get; set; }
        public string createdon { get; set; }
        public string updatedon { get; set; }
        public string order { get; set; }
    }
}