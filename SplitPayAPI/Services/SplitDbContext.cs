using SplitPayAPI.Models;
using System.Data.Entity;

namespace SplitPayAPI.Services
{
    public class SplitDbContext : DbContext
    {
        public SplitDbContext()
            : base("name=SplitDb")
        {
        }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<SellerTransaction> SellerTransaction { get; set; }
    }
}