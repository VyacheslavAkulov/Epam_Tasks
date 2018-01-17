using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Akulov_Viacheslav.DAL.DbContexts;
using Task_2_Akulov_Viacheslav.DAL.Interfaces;
using Task_2_Akulov_Viacheslav.Models;

namespace Task_2_Akulov_Viacheslav.DAL.Repositories
{
    /// <summary>
    /// Implementing the repository for the essence of the Article
    /// </summary>
    public class ArticleRepository : IRepository<Article>
    {
        /// <summary>
        /// Database context
        /// </summary>
        private SiteContext db;

        /// <summary>
        /// Initializing the context of the database
        /// </summary>
        /// <param name="db">Database context</param>
        public ArticleRepository(SiteContext db)
        {
            this.db = db;
        }

        /// <summary>
        /// Adding an object to the database
        /// </summary>
        /// <param name="item">Adding object</param>
        void IRepository<Article>.Add(Article item)
        {
            db.Articles.Add(item);
        }

        void IRepository<Article>.Delete(int? id)
        {
            Article article = db.Articles.Find(id);
            if (article != null)
                db.Articles.Remove(article);
        }

        Article IRepository<Article>.Get(int id)
        {
            return db.Articles.Find(id);
        }

        /// <summary>
        /// Getting all objects of this entity in the database
        /// </summary>
        /// <returns>List of all objects</returns>
        IEnumerable<Article> IRepository<Article>.GetAll()
        {
            return db.Articles;
        }
    }
}
