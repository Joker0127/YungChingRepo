using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace YungChingProj.ControllerAPI
{
    public class TestController : ApiController
    {
        public string Get()
        {
            return "Hi Man!";
        }
        public List<string> Get(int Id)
        {
            return new List<string> {
                "Data1",
                "Data2"
            };
        }
    }
}
