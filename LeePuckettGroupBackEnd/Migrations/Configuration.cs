namespace LeePuckettGroupBackEnd.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LeePuckettGroupBackEnd.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<LeePuckettGroupBackEnd.DAL.DB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }


        protected override void Seed(LeePuckettGroupBackEnd.DAL.DB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Contact.AddOrUpdate(p => p.Contact_Id,
            new Contact() { Contact_Id = 1, FirstName = "Lee", LastName = "Puckett", City = "Louisville", State = "Kentucky", Country = "United States" },
            new Contact() { Contact_Id = 1, FirstName = "Roy", LastName = "Rogers", City = "Dallas", State = "Texas", Country = "United States" }

            );
        }
    }
}
