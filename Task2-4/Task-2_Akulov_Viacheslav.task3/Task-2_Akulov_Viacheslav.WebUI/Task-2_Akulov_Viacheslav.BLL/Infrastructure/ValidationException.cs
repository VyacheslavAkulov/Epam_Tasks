
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task_2_Akulov_Viacheslav.BLL.Infrastructure
{
    /// <summary>
    /// Validate model exceptions
    /// </summary>
    public class ValidationException : Exception
    {
        /// <summary>
        /// The name of the model property that is incorrect and does not pass validation
        /// </summary>
        public string Property { get; protected set; }
        /// <summary>
        /// Initializes a new exception object
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="prop">The name of the model property that is incorrect and does not pass validation</param>
        public ValidationException(string message, string prop) : base(message)
        {
            Property = prop;
        }
    }
}