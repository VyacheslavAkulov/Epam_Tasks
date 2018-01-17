using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task_2_Akulov_Viacheslav.WebUI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ProgrammingLanguage { get; set; }
        public ApplicationUser()
        {
        }
    }
}