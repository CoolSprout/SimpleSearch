namespace SimpleSearch.Migrations
{
    using MySearchApp.Models.Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleSearch.DataAccess.Context.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleSearch.DataAccess.Context.PersonContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Persons.Add(new Person { FirstName = "sourav", LastName = "kayal", Address = "123 Street, NYC", Age = 35, Intrest = "Movies" });
            context.Persons.Add(new Person { FirstName = "foo", LastName = "bar", Address = "123 Street, CNT", Age = 25, Intrest = "Songs" });
            context.Persons.Add(new Person { FirstName = "Johnson", LastName = "Joseph", Address = "123 Street, WDC", Age = 45, Intrest = "Hiking" });
            context.SaveChanges();
        }
    }
}
