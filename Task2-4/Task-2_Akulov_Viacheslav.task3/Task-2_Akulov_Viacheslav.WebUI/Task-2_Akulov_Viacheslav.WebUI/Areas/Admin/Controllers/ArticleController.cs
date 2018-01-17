using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2_Akulov_Viacheslav.BLL.Interfaces;
using Task_2_Akulov_Viacheslav.Models;

namespace Task_2_Akulov_Viacheslav.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles ="admin")]
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
        [HttpGet]
        public ActionResult ViewArticles()
        {
            return View(siteService.Articles.GetAll());
        }
        [HttpPost]
        public ActionResult ViewArticles(int? id=null)
        {
            if (id == null)
            {
                new HttpNotFoundResult();
            }

            siteService.Articles.Delete(id);
            return RedirectToAction("ViewArticles");

        }
        public PartialViewResult DeleteArticles()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult AddNewArticle()
        {
            ViewBag.Tags = siteService.Tags.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult AddNewArticle(Article article, string[] Tags)
        {
            if (article.Tags.Count !=0)
            {
                foreach (var item in Tags)
                {
                    article.Tags.Add(siteService.Tags.GetAll().Where(tag => tag.Name == item).First());
                }
            }
            article.Date = DateTime.Now;
            siteService.Articles.Add(article);
            
            return RedirectToAction("ViewArticles");
        }
        public PartialViewResult Tags()
        {
            return PartialView();
        }

    }
}