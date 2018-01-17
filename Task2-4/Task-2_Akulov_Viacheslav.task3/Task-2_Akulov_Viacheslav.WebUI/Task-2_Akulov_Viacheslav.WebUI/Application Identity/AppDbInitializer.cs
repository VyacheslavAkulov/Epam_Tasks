﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Task_2_Akulov_Viacheslav.WebUI.IdentityContext;
using Task_2_Akulov_Viacheslav.WebUI.Models;

namespace Task_2_Akulov_Viacheslav.WebUI.Application_Identity
{
    public class AppDbInitializer: CreateDatabaseIfNotExists<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var role1 = new IdentityRole { Name = "admin" };
            var role2 = new IdentityRole { Name = "user" };

            roleManager.Create(role1);
            roleManager.Create(role2);


            var admin = new ApplicationUser { Email = "admin@gmail.ru", UserName = "admin@gmail.ru",ProgrammingLanguage="C#" };
            string password = "asdfgh";
            var result = userManager.Create(admin, password);

            if (result.Succeeded)
            {
                userManager.AddToRole(admin.Id, role1.Name);
            }

            base.Seed(context);
        }
    }
}