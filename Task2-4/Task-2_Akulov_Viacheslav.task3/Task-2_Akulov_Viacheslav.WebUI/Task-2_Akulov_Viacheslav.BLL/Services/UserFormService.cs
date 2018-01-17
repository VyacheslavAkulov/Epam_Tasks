using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Akulov_Viacheslav.BLL.Infrastructure;
using Task_2_Akulov_Viacheslav.BLL.Interfaces;
using Task_2_Akulov_Viacheslav.DAL.Interfaces;
using Task_2_Akulov_Viacheslav.Models;

namespace Task_2_Akulov_Viacheslav.BLL.Services
{
    /// <summary>
    /// Interaction between the database layer and the view layer for the entity UserForm
    /// Implementing a communication service
    /// </summary>
    public class UserFormService : IService<UserForm>
    {
        /// <summary>
        /// Database object
        /// </summary>
        IUnitOfWork Database;

        /// <summary>
        /// Initializing the database
        /// </summary>
        /// <param name="database"></param>
        public UserFormService(IUnitOfWork database)
        {
            Database = database;
        }

        /// <summary>
        /// Model validation
        /// </summary>
        /// <param name="modelDTO">Validation object</param>
        public void Validate(UserForm modelDTO)
        {
            if (modelDTO == null)
            {
                throw new ValidationException("Заполните поля", "");
            }
            if (string.IsNullOrEmpty(modelDTO.Name))
            {
                throw new ValidationException("Введите ваше имя", "");
            }
            if (modelDTO.Age < 0 || modelDTO.Age > 100)
            {
                throw new ValidationException("Введены некоректный возраст", "");
            }
            if (modelDTO.Salary < 0)
            {
                throw new ValidationException("Введены некоректная зарплата", "");
            }
            if (string.IsNullOrEmpty(modelDTO.Team))
            {
                throw new ValidationException("Введите название команды", "");
            }
        }

        /// <summary>
        /// Adding a new item
        /// </summary>
        /// <param name="modelDTO"> Adding item</param>
        void IService<UserForm>.Add(UserForm modelDTO)
        {

            Validate(modelDTO);
            UserForm userForm = modelDTO;
            Database.UserForms.Add(userForm);
            Database.Save();
        }

        void IService<UserForm>.Delete(int? id)
        {
        }

        UserForm IService<UserForm>.Get(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id форма", "");
            var userForm = Database.UserForms.Get(id.Value);
            if (userForm == null)
                throw new ValidationException("Сатья  не найдена не форма", "");
            return userForm;
        }

        /// <summary>
        /// Getting all objects of this entity in the database
        /// </summary>
        /// <returns>List of all objects</returns>
        IEnumerable<UserForm> IService<UserForm>.GetAll()
        {
            return Database.UserForms.GetAll();
        }

        void IService<UserForm>.Validate(UserForm modelDTO)
        {
            
        }
    }
}
