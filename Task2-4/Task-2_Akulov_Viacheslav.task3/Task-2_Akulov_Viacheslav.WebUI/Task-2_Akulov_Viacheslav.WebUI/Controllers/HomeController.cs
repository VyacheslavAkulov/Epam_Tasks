using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2_Akulov_Viacheslav.BLL.Infrastructure;
using Task_2_Akulov_Viacheslav.BLL.Interfaces;
using Task_2_Akulov_Viacheslav.Models;
using Task_2_Akulov_Viacheslav.WebUI.Models;

namespace Task_2_Akulov_Viacheslav.WebUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        /// <summary>
        /// Service to work with Database
        /// </summary>
        ISiteService siteService;
        /// <summary>
        /// Initialize Database service
        /// </summary>
        /// <param name="siteService">Database service</param>
        public HomeController(ISiteService siteService)
        {
            this.siteService = siteService;
        }
        /// <summary>
        /// Action that processes requests to the main page
        /// </summary>
        /// <returns>Page with articles</returns>
        [HttpGet]
        public ActionResult Index()
        {
            
            IEnumerable<Article> articles = siteService.Articles.GetAll();
            return View(articles);
        }
        [HttpPost]
        public ActionResult Index(bool? Love)
        {
            ViewBag.Love = Love;
            IEnumerable<Article> articles = siteService.Articles.GetAll();
            return View(articles);
        }
        public ActionResult QuizPartial()
        {
            return View();
        }
        /// <summary>
        /// Dispose resources
        /// </summary>
        /// <param name="disposing">
        /// true-Resources were disposed
        /// false-Resources weren't disposed 
        /// </param>
        protected override void Dispose(bool disposing)
        {
            siteService.Dispose();
            base.Dispose(disposing);
        }

    }
}