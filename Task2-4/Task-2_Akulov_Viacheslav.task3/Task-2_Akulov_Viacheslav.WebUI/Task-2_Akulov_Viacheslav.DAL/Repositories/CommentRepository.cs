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
    /// Implementing the repository for the essence of the Comment
    /// </summary>
    public class CommentRepository : IRepository<Comment>
    {
        /// <summary>
        /// Database context
        /// </summary>
        private SiteContext db;

        /// <summary>
        /// Initializing the context of the database
        /// </summary>
        /// <param name="db">Database context</param>
        public CommentRepository(SiteContext db)
        {
            this.db = db;
        }

        /// <summary>
        /// Adding an object to the database
        /// </summary>
        /// <param name="item">Adding object</param>
        void IRepository<Comment>.Add(Comment item)
        {
            db.Comments.Add(item);
        }

        void IRepository<Comment>.Delete(int? id)
        {
        }

        Comment IRepository<Comment>.Get(int id)
        {
            return db.Comments.Find(id);
        }

        /// <summary>
        /// Getting all objects of this entity in the database
        /// </summary>
        /// <returns>List of all objects</returns>
        IEnumerable<Comment> IRepository<Comment>.GetAll()
        {
            return db.Comments;
        }
    }
}
