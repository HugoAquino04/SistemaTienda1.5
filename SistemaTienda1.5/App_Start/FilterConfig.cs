﻿using System.Web;
using System.Web.Mvc;

namespace SistemaTienda1._5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
