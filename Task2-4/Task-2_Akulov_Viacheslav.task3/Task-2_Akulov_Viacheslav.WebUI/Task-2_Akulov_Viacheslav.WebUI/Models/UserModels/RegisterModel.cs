using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task_2_Akulov_Viacheslav.WebUI.Models.ApplicationViewModels
{
    public class RegisterModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string ProgrammingLanguage { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}