using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Akulov_Viacheslav.DAL.DbContexts;
using Task_2_Akulov_Viacheslav.DAL.Interfaces;
using Task_2_Akulov_Viacheslav.Model.Models;
using Task_2_Akulov_Viacheslav.Models;

namespace Task_2_Akulov_Viacheslav.DAL.Repositories
{
    /// <summary>
    /// Class to work with the entities of database
    /// </summary>dependency injection
    public class DbContextUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Database context
        /// </summary>
        private SiteContext db;

        /// <summary>
        /// Repository objects for database entities
        /// </summary>
        private ArticleRepository articleRepository;
        private CommentRepository commentRepository;
        private UserFormRepository userFormRepository;
        private TagRepository tagRepository;

        /// <summary>
        /// Database initialization
        /// </summary>
        /// <param name="connectionString">Connection string name</param>
        public DbContextUnitOfWork(string connectionString)
        {
            db = new SiteContext(connectionString);
        }

        /// <summary>
        /// Getter for Article repository
        /// </summary>
        public IRepository<Article> Articles
        {
            get
            {
                if (articleRepository == null)
                    articleRepository = new ArticleRepository(db);
                return articleRepository;
            }
        }

        /// <summary>
        /// Getter for Comment repository
        /// </summary>
        public IRepository<Comment> Comments
        {
            get
            {
                if (commentRepository == null)
                    commentRepository = new CommentRepository(db);
                return commentRepository;
            }
        }

        /// <summary>
        /// Getter for UserForm repository
        /// </summary>
        public IRepository<UserForm> UserForms
        {
            get
            {
                if (userFormRepository == null)
                    userFormRepository = new UserFormRepository(db);
                return userFormRepository;
            }
        }

        public IRepository<Tag> Tags
        {
            get
            {
                if (tagRepository == null)
                    tagRepository = new TagRepository(db);
                return tagRepository;
            }
        }

        /// <summary>
        /// Saving database changes
        /// </summary>
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        /// <summary>
        /// Dispose resources
        /// </summary>
        /// <param name="disposing">
        /// true-Resources were disposed
        /// false-Resources weren't disposed 
        /// </param>
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        /// <summary>
        /// Dispose resources
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
