using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace webapi.Models
{
    public class common
    {
        public static string connectionString
        {
            get
            {
                return GetAppSetting("connectionString");
            }
        }



        public static string GetAppSetting(string Attr)
        {
            return ConfigurationManager.AppSettings.Get(Attr);
        }

    }
}