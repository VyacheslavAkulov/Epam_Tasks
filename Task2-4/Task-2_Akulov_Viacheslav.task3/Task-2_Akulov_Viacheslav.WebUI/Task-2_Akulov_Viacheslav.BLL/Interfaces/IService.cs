using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Akulov_Viacheslav.BLL.Interfaces
{
    /// <summary>
    /// Service interface
    /// </summary>
    /// <typeparam name="T">Entity</typeparam>
    public interface IService<T> where T : class
    {
        /// <summary>
        /// Get Element by id
        /// </summary>
        /// <param name="id">Element id</param>
        /// <returns></returns>
        T Get(int? id);
        /// <summary>
        /// Get all entity objects to be sent to the view
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Adding a new item received from a view
        /// </summary>
        /// <param name="modelDTO">Entity object</param>
        void Add(T modelDTO);

        /// <summary>
        /// Model validation
        /// </summary>
        /// <param name="modelDTO">Validation object</param>
        void Validate(T modelDTO);

        void Delete(int? id);
    }
}
