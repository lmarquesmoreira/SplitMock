using SplitPayAPI.Contracts;
using SplitPayAPI.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Newtonsoft.Json;
using SplitPayAPI.Models;

namespace SplitPayAPI.Controllers
{
    public class SplitController : ApiController
    {
        public SplitService SplitService { get; set; }
        public SplitController()
        {
            SplitService = new SplitService();
        }

        public IHttpActionResult Get()
        {
            try
            {
                return Content(System.Net.HttpStatusCode.OK, SplitService.GetTransactions());
            }
            catch (Exception)
            {

                return Content(System.Net.HttpStatusCode.BadRequest, "Deu merda.");
            }
        }

        // POST api/values
        public IHttpActionResult Post([FromBody]Contracts.Transaction transaction)
        {
            try
            {
                var model = new Models.Transaction()
                {
                    amount = transaction.amount,
                    order = JsonConvert.SerializeObject(transaction.order),
                    createdon = DateTime.UtcNow.ToShortDateString()
                };
                return Content(System.Net.HttpStatusCode.OK, SplitService.CreateTransaction(model, transaction.Sellers));
            }
            catch (Exception)
            {

                return Content(System.Net.HttpStatusCode.BadRequest, "Deu merda.");
            }
           
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
