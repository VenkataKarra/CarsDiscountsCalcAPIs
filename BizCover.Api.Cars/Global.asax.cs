﻿using System.Web.Http;
using System.Web.Mvc;

namespace BizCover.Api.Cars
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            UnityConfig.RegisterTypes(UnityConfig.Container);
        }
    }
}
