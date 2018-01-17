using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Akulov_Viacheslav.BLL.Infrastructure;
using Task_2_Akulov_Viacheslav.BLL.Interfaces;
using Task_2_Akulov_Viacheslav.DAL.Interfaces;
using Task_2_Akulov_Viacheslav.Model.Models;

namespace Task_2_Akulov_Viacheslav.BLL.Services
{
    class TagService:IService<Tag>
    {
        IUnitOfWork Database;

        public TagService(IUnitOfWork database)
        {
            Database = database;
        }

        void IService<Tag>.Add(Tag modelDTO)
        {
            Tag tag = modelDTO;
            Database.Tags.Add(tag);
            Database.Save();
        }

        void IService<Tag>.Delete(int? id)
        {
        }

        Tag IService<Tag>.Get(int? id)
        {
            if (id == null)
                throw new ValidationException("Не установлено id коментария", "");
            var tag = Database.Tags.Get(id.Value);
            if (tag == null)
                throw new ValidationException("Коментарий не найден", "");
            return tag;
        }

        IEnumerable<Tag> IService<Tag>.GetAll()
        {
            return Database.Tags.GetAll();
        }

        void IService<Tag>.Validate(Tag modelDTO)
        {
            
        }
    }
}
