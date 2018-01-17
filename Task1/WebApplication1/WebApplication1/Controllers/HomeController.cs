using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        DBContext context = new DBContext();
        public ActionResult Index()
        {
            ViewBag.Header = "Main Paage";
            return View(model: context.Notes);
        }
        public ActionResult Form(Form form = null)
        {
            ViewBag.Header = "Form page";
            if (Request.HttpMethod == "GET")
            {
                return View();
            }
            if (Request.HttpMethod == "POST")
            {
                if (form != null)
                {
                    context.Forms.Add(form);
                    context.SaveChanges();
                    return View("FormComplete", form);
                }

            }
            return HttpNotFound();
        }
        [HttpGet]
        public ActionResult Guestbook()
        {
            ViewBag.Header = "Guestbook page";
            return View(model: context.Reviews);
        }
        [HttpPost]
        public ActionResult Guestbook(Review review)
        {
            review.Date = DateTime.Now;
            context.Reviews.Add(review);
            context.SaveChanges();
            return RedirectToAction("Guestbook");
        }
        public PartialViewResult GuestbookPartial()
        {
            return PartialView();
        }
        public ActionResult FormComplete()
        {
            return View();
        }
    }
}