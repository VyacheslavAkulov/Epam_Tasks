using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Form
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