namespace Identity.Migrations.ApplicationDbContext
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Config : DbMigrationsConfiguration<Identity.Models.ApplicationDbContext>
    {
        public Config()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ApplicationDbContext";
            ContextKey = "Identity.Models.ApplicationDbContext";
        }

        protected override void Seed(Identity.Models.ApplicationDbContext context)
        {

            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var rolerSuperAdminesult = roleManager.Create(new IdentityRole("SuperAdmin"));

            //var passwordHash = new PasswordHasher();
            //string password = passwordHash.HashPassword("Password@123");

            //ApplicationUser SuperUser = new ApplicationUser();

            //SuperUser.Email = "Steve@Steve.com";
            //SuperUser.UserName = "Steve";

            //int suoerUderId = context.Users.Single(c => c.UserName == "Steve").Id;

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            

            var result = userManager.Create(user: new ApplicationUser() { UserName = "Steve@Steve.com", Email = "Steve@Steve.com" }, password: "Password@123");
            var user = userManager.FindByName("Steve@Steve.com");
            userManager.AddToRole(user.Id, "SuperAdmin");


            //if (!result.Succeeded)
            //{
            //    File.Create("nope.txt");
            //}

            //    );
            //
        }
    }
}
