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
    /// Implementing the repository for the essence of the UserForm
    /// </summary>
    public class UserFormRepository : IRepository<UserForm>
    {
        /// <summary>
        /// Database context
        /// </summary>
        private SiteContext db;

        /// <summary>
        /// Initializing the context of the database
        /// </summary>
        /// <param name="db">Database context</param>
        public UserFormRepository(SiteContext db)
        {
            this.db = db;
        }
        /// <summary>
        /// Adding an object to the database
        /// </summary>
        /// <param name="item">Adding object</param>
        void IRepository<UserForm>.Add(UserForm item)
        {
            db.UserForms.Add(item);
        }

        void IRepository<UserForm>.Delete(int? id)
        {
        }

        UserForm IRepository<UserForm>.Get(int id)
        {
            return db.UserForms.Find(id);
        }

        /// <summary>
        /// Getting all objects of this entity in the database
        /// </summary>
        /// <returns>List of all objects</returns>
        IEnumerable<UserForm> IRepository<UserForm>.GetAll()
        {
            return db.UserForms;
        }
    }
}
