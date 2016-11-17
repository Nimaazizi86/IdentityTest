namespace Identity.Migrations
{

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Identity.Models.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Identity.Models.PersonContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            ////
            //context.Countries.AddOrUpdate(
            //              p => p.Name,
            //              new Country { Name = "Sweden" }
            //            );
            //int land = context.Countries.Single(c => c.Name == "Sweden").Id;

            //context.Cities.AddOrUpdate(
            //  p => p.Name,
            //  new City { Name = "Jönköping", CountryId = land },
            //  new City { Name = "Malmö", CountryId = land }
            //);
            //int stad = context.Cities.Single(c => c.Name == "Jönköping").ID;

            //context.People.AddOrUpdate(
            //  p => p.Name,
            //  new Person { Name = "Nima", PersonalNumber = "8609214518", countryId = stad, cityId = stad }
            //);

            //var roleStore = new RoleStore<IdentityRole>(context);
            //var roleManager = new RoleManager<IdentityRole>(roleStore);

            //var rolerSuperAdminesult = roleManager.Create(new IdentityRole("SuperAdmin"));

            ////var passwordHash = new PasswordHasher();
            ////string password = passwordHash.HashPassword("Password@123");

            //ApplicationUser SuperUser = new ApplicationUser();

            //SuperUser.Email = "Steve@Steve.com";
            //SuperUser.UserName = "Steve";

            //var userStore = new UserStore<ApplicationUser>(context);
            //var userManager = new UserManager<ApplicationUser>(userStore);

            //var result = userManager.Create( SuperUser, "Password@123");

            //if (!result.Succeeded)
            //{
            //    File.Create("nope.txt");
            //}


        }



    }

}
