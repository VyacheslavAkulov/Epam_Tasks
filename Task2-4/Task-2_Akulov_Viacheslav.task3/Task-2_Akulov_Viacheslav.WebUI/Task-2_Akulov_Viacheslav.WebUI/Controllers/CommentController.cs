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
    public class CommentController : Controller
    {
        /// <summary>
        /// Service to work with Database
        /// </summary>
        ISiteService siteService;

        /// <summary>
        /// Initialize Database service
        /// </summary>
        /// <param name="siteService">Database service</param>
        public CommentController(ISiteService siteService)
        {
            this.siteService = siteService;
        }

        /// <summary>
        /// Processing get requests to Comment
        /// </summary>
        /// <returns>Comment page</returns>
        [HttpGet]
        public ActionResult Comment()
        {
            IEnumerable<Comment> comments = siteService.Comments.GetAll();
            return View(comments);
        }

        /// <summary>
        /// Processing post requests to Comment
        /// </summary>
        /// <param name="commentViewModel">Added comment</param>
        /// <returns>Comments page</returns>
        [HttpPost]
        public ActionResult Comment(CommentViewModel commentViewModel)
        {
            try
            {
                Comment comment = new Comment
                {
                    Name = commentViewModel.Name,
                    Text = commentViewModel.Text,
                    Date = DateTime.Now
                };
                siteService.Comments.Add(comment);
                return RedirectToAction("Comment");
            }
            catch (ValidationException ex)
            {
                return Content(ex.Message);
            }

        }

        /// <summary>
        ///  Processing get requests to CommentPartial
        /// </summary>
        /// <returns>Form for adding a comment</returns>
        [Authorize]
        public PartialViewResult CommentPartial()
        {
            return PartialView();
        }
    }
}