using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_2_Akulov_Viacheslav.BLL.Infrastructure;
using Task_2_Akulov_Viacheslav.BLL.Interfaces;
using Task_2_Akulov_Viacheslav.Models;

namespace Task_2_Akulov_Viacheslav.WebUI.Controllers
{
    [Authorize]
    public class UserFormController : Controller
    {
        /// <summary>
        /// Service to work with Database
        /// </summary>
        ISiteService siteService;
        /// <summary>
        /// Initialize Database service
        /// </summary>
        /// <param name="siteService">Database service</param>
        public UserFormController(ISiteService siteService)
        {
            this.siteService = siteService;
        }
        // GET: UserForm
        /// <summary>
        /// Processing requests to UserForm
        /// Adding the user information
        /// </summary>
        /// <param name="form">Form filled by the user</param>
        /// <returns>
        /// Get-User input form
        /// Post-Page with input information
        /// </returns>
        public ActionResult UserForm(UserForm form = null)
        {
            if (Request.HttpMethod == "GET")
            {
                return View();
            }
            if (Request.HttpMethod == "POST")
            {
                try
                {
                    siteService.UserForms.Add(form);
                    return View("UserFormComplete", form);
                }
                catch (ValidationException ex)
                {
                    return Content(ex.Message);
                }

            }
            return HttpNotFound();
        }
        /// <summary>
        /// Processing requests to UserForm
        /// </summary>
        /// <returns>Page with input information</returns>
        public ActionResult UserFormComplete()
        {
            return View();
        }
    }
}