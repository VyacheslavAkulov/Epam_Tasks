using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2_Akulov_Viacheslav.BLL.Interfaces;

namespace Task_2_Akulov_Viacheslav.WebUI.Controllers
{
    [AllowAnonymous]
    public class ArticleController : Controller
    {
        /// <summary>
        /// Service to work with Database
        /// </summary>
        ISiteService siteService;
        /// <summary>
        /// Initialize Database service
        /// </summary>
        /// <param name="siteService">Database service</param>
        public ArticleController(ISiteService siteService)
        {
            this.siteService = siteService;
        }
        public ActionResult ArticleInfo(int? Id)
        {
            return View(siteService.Articles.Get(Id));
        }
    }
}