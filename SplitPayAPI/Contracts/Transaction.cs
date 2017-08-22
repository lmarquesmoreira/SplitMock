using Newtonsoft.Json.Linq;
using SplitPayAPI.Models;
using System.Collections.Generic;

namespace SplitPayAPI.Contracts
{
    public class Transaction
    {
        public string amount { get; set; }
        public JObject order { get; set; }
        public List<Seller> Sellers { get; set; }
    }
}