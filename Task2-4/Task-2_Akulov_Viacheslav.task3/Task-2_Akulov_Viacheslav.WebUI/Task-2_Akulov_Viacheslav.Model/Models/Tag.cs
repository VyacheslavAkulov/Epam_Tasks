using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Akulov_Viacheslav.Models;

namespace Task_2_Akulov_Viacheslav.Model.Models
{
    public class Tag
    {
        public Tag()
        {
            Articles = new List<Article>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
