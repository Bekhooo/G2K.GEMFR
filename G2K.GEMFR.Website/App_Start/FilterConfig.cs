﻿using System.Web;
using System.Web.Mvc;

namespace G2K.GEMFR.Website
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
