using MySearchApp.Models.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace SimpleSearch.DataAccess.Context
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("PersonDB")
        {
            Database.SetInitializer<PersonContext>(new PersonDBInitializer());
        }
        public DbSet<Person> Persons { get; set; }
    }
    public class PersonDBInitializer : CreateDatabaseIfNotExists<PersonContext>
    {
        List<Person> persons = new List<Person>();
        public PersonDBInitializer()
        {
            persons.Add(new Person { FirstName = "sourav", LastName = "kayal", Address = "123 Street, NYC", Age = 35, Intrest = "Movies" });
            persons.Add(new Person { FirstName = "foo", LastName = "bar", Address = "123 Street, CNT", Age = 35, Intrest = "Songs" });
        }
        protected override void Seed(PersonContext context)
        {
            foreach (Person p in persons)
            {
                context.Persons.Add(p);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
