﻿using System.Web;
using System.Web.Mvc;

namespace bai3._1_tulam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
