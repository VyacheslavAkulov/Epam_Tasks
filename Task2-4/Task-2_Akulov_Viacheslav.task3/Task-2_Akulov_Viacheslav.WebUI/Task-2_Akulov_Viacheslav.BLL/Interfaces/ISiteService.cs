using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Akulov_Viacheslav.Model.Models;
using Task_2_Akulov_Viacheslav.Models;

namespace Task_2_Akulov_Viacheslav.BLL.Interfaces
{
    /// <summary>
    /// Providing access to services
    /// Defining the general context for services
    /// </summary>
    public interface ISiteService:IDisposable
    {
        /// <summary>
        /// Providing access to Article service
        /// </summary>
        IService<Article> Articles { get; }
        /// <summary>
        /// Providing access to Comment service
        /// </summary>
        IService<Comment> Comments { get; }
        /// <summary>
        /// Providing access to UserForm service
        /// </summary>
        IService<UserForm> UserForms { get; }

        IService<Tag> Tags { get; }
    }
}
