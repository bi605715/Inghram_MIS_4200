﻿using System.Web;
using System.Web.Mvc;

namespace Inghram_MIS_4200
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
