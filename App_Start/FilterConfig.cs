﻿using System.Web;
using System.Web.Mvc;

namespace WE_Asgn_2_a
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
