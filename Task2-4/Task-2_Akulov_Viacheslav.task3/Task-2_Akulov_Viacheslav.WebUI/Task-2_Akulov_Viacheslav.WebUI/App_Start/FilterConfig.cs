using System.Web;
using System.Web.Mvc;

namespace Task_2_Akulov_Viacheslav.WebUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
