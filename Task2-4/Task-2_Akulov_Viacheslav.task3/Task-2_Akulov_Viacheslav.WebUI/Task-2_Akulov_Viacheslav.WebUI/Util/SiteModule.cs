using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task_2_Akulov_Viacheslav.BLL.Interfaces;
using Task_2_Akulov_Viacheslav.BLL.Services;

namespace Task_2_Akulov_Viacheslav.WebUI.Util
{
    /// <summary>
    /// Dependency injection module
    /// </summary>
    public class SiteModule:NinjectModule
    {
        /// <summary>
        /// Dependency injection beetwen ISiteService and SiteService
        /// </summary>
        public override void Load()
        {
            Bind<ISiteService>().To<SiteService>();
        }
    }
}