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
    /// Interaction between the database layer and the view layer for the entity Comment
    /// Implementing a communication service
    /// </summary>
    public class CommentService : IService<Comment>
    {
        /// <summary>
        /// Database object
        /// </summary>
        IUnitOfWork Database;

        /// <summary>
        /// Initializing the database
        /// </summary>
        /// <param name="database"></param>
        public CommentService(IUnitOfWork database)
        {
            Database = database;
        }

        /// <summary>
        /// Model validation
        /// </summary>
        /// <param name="modelDTO">Validation object</param>
        public void Validate(Comment modelDTO)
        {
            if (modelDTO == null)
            {
                throw new ValidationException("Заполните поля", "");
            }
            if (string.IsNullOrEmpty(modelDTO.Name))
            {
                throw new ValidationException("Введите ваше имя", "");
            }
            if (string.IsNullOrEmpty(modelDTO.Text))
            {
                throw new ValidationException("Введите текст отзыва", "");
            }
        }

        /// <summary>
        /// Adding a new item
        /// </summary>
        /// <param name="modelDTO"> Adding item</param>
        void IService<Comment>.Add(Comment modelDTO)
        {
            Comment comment = modelDTO;
                Database.Comments.Add(comment);
                Database.Save();

            
        }

        void IService<Comment>.Delete(int? id)
        {
        }

        Comment IService<Comment>.Get(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id коментария", "");
            var comment = Database.Comments.Get(id.Value);
            if (comment == null)
                throw new ValidationException("Коментарий не найден", "");
            return comment;
        }

        /// <summary>
        /// Getting all objects of this entity in the database
        /// </summary>
        /// <returns>List of all objects</returns>
        IEnumerable<Comment> IService<Comment>.GetAll()
        {
            return Database.Comments.GetAll();
        }

        void IService<Comment>.Validate(Comment modelDTO)
        {
           
        }
    }
}
