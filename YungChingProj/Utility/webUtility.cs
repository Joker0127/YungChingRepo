using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace YungChingProj.Utility
{
    public class webUtility
    {
        public static string WebConfig_GetValue(string key)
        {
            return WebConfigurationManager.AppSettings[key];
        }
    }
}