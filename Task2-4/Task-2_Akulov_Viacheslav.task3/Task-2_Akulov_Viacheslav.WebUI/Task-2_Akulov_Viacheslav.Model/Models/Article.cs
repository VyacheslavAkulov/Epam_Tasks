using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Akulov_Viacheslav.Model.Models;

namespace Task_2_Akulov_Viacheslav.Models
{
    /// <summary>
    /// Article entity
    /// </summary>
    public class Article
    {
        public Article()
        {
            Tags = new List<Tag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public string Text { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
