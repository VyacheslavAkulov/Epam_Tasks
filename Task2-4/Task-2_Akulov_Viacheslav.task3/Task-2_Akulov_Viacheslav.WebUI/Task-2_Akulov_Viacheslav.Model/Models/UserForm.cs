using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Akulov_Viacheslav.Models
{
    /// <summary>
    /// UserForm entity
    /// </summary>
    public class UserForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public int Age { get; set; }
        public string Team { get; set; }
        public int Position { get; set; }
        public int Salary { get; set; }
    }
}
