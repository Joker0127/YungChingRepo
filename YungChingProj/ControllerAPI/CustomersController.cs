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
    }
}
