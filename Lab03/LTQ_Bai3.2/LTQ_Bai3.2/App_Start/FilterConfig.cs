﻿using System.Web;
using System.Web.Mvc;

namespace LTQ_Bai3._2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}