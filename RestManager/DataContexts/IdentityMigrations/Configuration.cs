using Microsoft.AspNet.Identity;
using RestManager.Models;
using System;
using System.Data.Entity.Migrations;

namespace RestManager.DataContexts.IdentityMigrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<IdentityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\IdentityMigrations";
        }

        protected override void Seed(IdentityContext context)
        {
            //  This method will be called after migrating to the latest version.

            var hasher = new PasswordHasher();
            var user = new ApplicationUser
            {
                Email = "henrique@mail.com",
                Name = "henrique",
                PhoneNumber = "1234567",
                UserName = "henrique@mail.com",
                PasswordHash = hasher.HashPassword("test"),
                SecurityStamp = Guid.NewGuid().ToString()
            };

            context.Users.AddOrUpdate(p => p.Email, user);
            context.SaveChanges();
        }
    }
}
