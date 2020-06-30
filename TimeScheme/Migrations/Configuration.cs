namespace TimeScheme.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using TimeScheme.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeScheme.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TimeScheme.Models.ApplicationDbContext";
        }

        protected override void Seed(TimeScheme.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            AddUsers(context); 
        }
        void AddUsers(TimeScheme.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "user1@email.com" };
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            um.Create(user, "password");
        }
    }
}
