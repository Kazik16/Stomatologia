using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Stomatologia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stomatologia.App_Start
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var rs = new RoleStore<IdentityRole>(context);
            var rm = new RoleManager<IdentityRole>(rs);

            rm.Create(new IdentityRole { Name = "Admins" });
            rm.Create(new IdentityRole { Name = "Pacjent" });
            rm.Create(new IdentityRole { Name = "Lekarz" });

            var us = new UserStore<ApplicationUser>(context);
            var um = new UserManager<ApplicationUser>(us);

            var user = new ApplicationUser { UserName = "admin@myapp.pl", Email = "admin@myapp.pl", EmailConfirmed = true };
            um.Create(user, "Admin123#");
            um.AddToRole(user.Id, "Admins");
        }
    }
}