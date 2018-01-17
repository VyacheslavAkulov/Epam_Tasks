using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Akulov_Viacheslav.DAL.Interfaces
{
    /// <summary>
    /// Repository interface
    /// </summary>
    /// <typeparam name="T">Entity</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Gett element by Id
        /// </summary>
        /// <param name="id">Id Element</param>
        /// <returns></returns>
        T Get(int id);
        /// <summary>
        /// Get all entity objects
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Adding a new item
        /// </summary>
        /// <param name="item">Entity object</param>
        void Add(T item);
        void Delete(int? id);
    }
}
