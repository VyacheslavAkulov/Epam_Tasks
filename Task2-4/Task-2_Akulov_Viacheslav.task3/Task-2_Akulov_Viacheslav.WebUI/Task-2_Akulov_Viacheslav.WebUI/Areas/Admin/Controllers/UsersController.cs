using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2_Akulov_Viacheslav.WebUI.Application_Identity;

namespace Task_2_Akulov_Viacheslav.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class UsersController : Controller
    {
        private ApplicationUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }
        // GET: Admin/ViewAll
        public ActionResult ViewAll()
        {
            return View(UserManager.Users.ToList());
        }
    }
}