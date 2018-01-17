using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Task_2_Akulov_Viacheslav.WebUI.Application_Identity;
using Task_2_Akulov_Viacheslav.WebUI.IdentityContext;

[assembly: OwinStartup(typeof(Task_2_Akulov_Viacheslav.WebUI.App_Start.Startup))]

namespace Task_2_Akulov_Viacheslav.WebUI.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }
    }
}
