﻿using System.Web.Mvc;

//namespace $rootnamespace$.App_Start
namespace RegistrationMVC.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}