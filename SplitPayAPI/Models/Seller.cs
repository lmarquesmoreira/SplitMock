using System.ComponentModel.DataAnnotations.Schema;

namespace SplitPayAPI.Models
{
    [Table("Sellers")]
    public class Seller
    {
        public int id { get; set; }
        public int mdr { get; set; }
        public string createdon { get; set; }
        public string updatedon { get; set; }
    }
}