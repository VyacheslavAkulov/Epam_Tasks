using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Akulov_Viacheslav.Model.Models;
using Task_2_Akulov_Viacheslav.Models;

namespace Task_2_Akulov_Viacheslav.DAL.Interfaces
{
    /// <summary>
    /// Providing access to repositories
    /// Defining the general context for repositories
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Getter for Article repository
        /// </summary>
        IRepository<Article> Articles { get; }
        /// <summary>
        /// Getter for Comment repository
        /// </summary>
        IRepository<Comment> Comments { get; }
        /// <summary>
        /// Getter for UserForm repository
        /// </summary>
        IRepository<UserForm> UserForms { get; }

        IRepository<Tag> Tags { get; }
        /// <summary>
        /// Saving database changes
        /// </summary>
        void Save();
    }
}
