using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YungChingProj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SiteSupport.DBManager.DBManager manager = new SiteSupport.DBManager.DBManager();
            System.Data.DataTable dt = manager.DB_GetDatatable("select * from Customers");


            return View();
        }
    }
}