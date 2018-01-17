using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Akulov_Viacheslav.DAL.DbContexts;
using Task_2_Akulov_Viacheslav.DAL.Interfaces;
using Task_2_Akulov_Viacheslav.Model.Models;

namespace Task_2_Akulov_Viacheslav.DAL.Repositories
{
    class TagRepository : IRepository<Tag>
    {
        private SiteContext db;

        public TagRepository(SiteContext db)
        {
            this.db = db;
        }

        void IRepository<Tag>.Add(Tag item)
        {
            db.Tags.Add(item);
        }

        void IRepository<Tag>.Delete(int? id)
        {
        }

        Tag IRepository<Tag>.Get(int id)
        {
            return db.Tags.Find(id);
        }

        IEnumerable<Tag> IRepository<Tag>.GetAll()
        {
            return db.Tags;
        }
    }
}
