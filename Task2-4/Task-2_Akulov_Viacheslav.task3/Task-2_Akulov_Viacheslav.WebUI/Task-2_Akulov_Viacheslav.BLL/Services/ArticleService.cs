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
    /// Interaction between the database layer and the view layer for the entity Article
    /// Implementing a communication service
    /// </summary>
    public class ArticleService : IService<Article>
    {
        /// <summary>
        /// Database object
        /// </summary>
        IUnitOfWork Database;

        /// <summary>
        /// Initializing the database
        /// </summary>
        /// <param name="database"></param>
        public ArticleService(IUnitOfWork database)
        {
            Database = database;
        }

        /// <summary>
        /// Model validation
        /// </summary>
        /// <param name="modelDTO">Validation object</param>
        public void Validate(Article modelDTO)
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
        void IService<Article>.Add(Article modelDTO)
        {
            Article article = modelDTO;          
            Database.Articles.Add(article);
            Database.Save();
        }

        void IService<Article>.Delete(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id статьи", "");
            var article = Database.Articles.Get(id.Value);
            if (article == null)
                throw new ValidationException("Сатья  не найдена не найден", "");
            Database.Articles.Delete(id);
            Database.Save();
        }

        Article IService<Article>.Get(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id статьи", "");
            var article = Database.Articles.Get(id.Value);
            if (article == null)
                throw new ValidationException("Сатья  не найдена не найден", "");
            return article;
        }

        /// <summary>
        /// Getting all objects of this entity in the database
        /// </summary>
        /// <returns>List of all objects</returns>
        IEnumerable<Article> IService<Article>.GetAll()
        {
            return Database.Articles.GetAll();
        }

        void IService<Article>.Validate(Article modelDTO)
        {
            
        }
    }
}
