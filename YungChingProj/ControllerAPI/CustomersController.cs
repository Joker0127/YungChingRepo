using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace YungChingProj.ControllerAPI
{
    public class CustomersController : ApiController
    {
        SiteSupport.SupportDB.SupportDB supportDB = new SiteSupport.SupportDB.SupportDB();

        //GET api/Customers
        [HttpGet]
        public string Get()
        {
            List<SiteSupport.Model.Customers> list = supportDB.Customers_Get();
            return JsonConvert.SerializeObject(list);
        }

        //GET api/Customers
        [HttpGet]
        public string Get(string id)
        {
            List<SiteSupport.Model.Customers> list = supportDB.Customers_Get(id);
            return JsonConvert.SerializeObject(list);
        }

        //Post api/Customers
        [HttpPost]
        public string Post(SiteSupport.Model.Customers customers)
        {
            bool ok = supportDB.Customers_Update(customers);
            return JsonConvert.SerializeObject(ok);
        }

        //Delete api/Customers
        [HttpDelete]
        public string Delete(string id)
        {
            bool ok = supportDB.Customers_Delete(id);
            return JsonConvert.SerializeObject(ok);
        }
    }
}
