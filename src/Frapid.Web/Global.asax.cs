﻿using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Frapid.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            LogManager.InternalizeLogger();
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            NPocoConfig.Register();
            StartupRegistration.Register();
        }
    }
}