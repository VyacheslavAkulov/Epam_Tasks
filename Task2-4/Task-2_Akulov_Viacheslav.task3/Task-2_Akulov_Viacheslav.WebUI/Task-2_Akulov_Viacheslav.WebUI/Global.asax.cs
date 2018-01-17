using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Task_2_Akulov_Viacheslav.BLL.Infrastructure;
using Task_2_Akulov_Viacheslav.WebUI.Application_Identity;
using Task_2_Akulov_Viacheslav.WebUI.IdentityContext;
using Task_2_Akulov_Viacheslav.WebUI.Util;
//using Task_2_Akulov_Viacheslav.WebUI.Util;

namespace Task_2_Akulov_Viacheslav.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<ApplicationContext>(new AppDbInitializer());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            NinjectModule siteModule = new SiteModule();
            NinjectModule serviceModule = new ServiceModule("DefaultConnection");
            var kernel = new StandardKernel(siteModule, serviceModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
