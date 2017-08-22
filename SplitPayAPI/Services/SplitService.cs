using SplitPayAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SplitPayAPI.Services
{
    public class SplitService
    {
        public SplitDbContext DbContext { get; set; }
        public SplitService()
        {
            DbContext = new SplitDbContext();
        }

        public string CreateTransaction(Transaction transaction, List<Seller> sellers)
        {
            try
            {
                foreach (var seller in sellers)
                {
                    var mdr = DbContext.Seller.Single(s=> s.id == seller.id).mdr;
                    var seller_amount = Convert.ToInt64(transaction.amount) * mdr / 100;
                    DbContext.SellerTransaction.Add(new SellerTransaction()
                    {
                        amount = seller_amount.ToString(),
                        seller_id = seller.id,
                        order = transaction.order,
                        createdon = DateTime.Now.ToShortDateString()
                    });
                    
                }
                DbContext.Transaction.Add(transaction);
                DbContext.SaveChanges();
                return "Transação Criada e Splitada com Sucesso!";
            }
            catch (Exception)
            {
                return "ferrou, deu erro";
            }
        }

        public List<SellerTransaction> GetTransactions()
        {
            return DbContext.SellerTransaction.ToList();
        }

    }
}