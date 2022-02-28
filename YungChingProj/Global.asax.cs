using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using YungChingProj.Utility;

namespace YungChingProj
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            //取得DB連線
            string dt_Server = webUtility.WebConfig_GetValue("dt_Server");
            string Database = webUtility.WebConfig_GetValue("Database");
            string DBuid = webUtility.WebConfig_GetValue("DBuid");
            string DBpwd = webUtility.WebConfig_GetValue("DBpwd");
            SiteSupport.DBManager.DBManager.DB_setConnectStr(dt_Server, Database, DBuid, DBpwd);
            //SiteSupport.DBManager.DBManager dBmanager = new SiteSupport.DBManager.DBManager(dt_Server, Database, DBuid, DBpwd);
        }
    }
}
