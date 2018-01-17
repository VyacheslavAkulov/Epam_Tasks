using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Akulov_Viacheslav.BLL.Infrastructure;
using Task_2_Akulov_Viacheslav.BLL.Interfaces;
using Task_2_Akulov_Viacheslav.DAL.Interfaces;
using Task_2_Akulov_Viacheslav.Model.Models;
using Task_2_Akulov_Viacheslav.Models;

namespace Task_2_Akulov_Viacheslav.BLL.Services
{
    /// <summary>
    ///  Interaction between the database layer and the view layer for the entities
    ///  Implementing a communication service
    /// </summary>
    public class SiteService : ISiteService
    {
        /// <summary>
        /// Database provider
        /// </summary>
        IUnitOfWork Database { get; set; }

        private ArticleService articleService;
        private CommentService commentService;
        private UserFormService userFormService;
        private TagService tagService;
        /// <summary>
        /// Database initialization
        /// </summary>
        /// <param name="database">Database provider</param>
        public SiteService(IUnitOfWork database)
        {
            Database = database;
        }
        /// <summary>
        /// Getter for Article service
        /// </summary>
        public IService<Article> Articles
        {
            get
            {
                if (articleService == null)
                    articleService = new ArticleService(Database);
                return articleService;
            }
        }
        /// <summary>
        /// Getter for Comment service
        /// </summary>
        public IService<Comment> Comments
        {
            get
            {
                if (commentService == null)
                    commentService = new CommentService(Database);
                return commentService;
            }
        }
        /// <summary>
        /// Getter for UserForm service
        /// </summary>
        public IService<UserForm> UserForms
        {
            get
            {
                if (userFormService == null)
                    userFormService = new UserFormService(Database);
                return userFormService;
            }
        }

        public IService<Tag> Tags
        {
            get
            {
                if (tagService == null)
                    tagService = new TagService(Database);
                return tagService;
            }
        }
        /// <summary>
        /// Dispose resources
        /// </summary>
        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
