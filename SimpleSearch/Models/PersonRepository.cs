using MySearchApp.Models.Entities;
using SimpleSearch.DataAccess.Context;
using SimpleSearch.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleSearch.DataAccess.Repository
{
    public class PersonRepository : IPersonRepository
    {
        //public void AddPerson(Person user)
        //{
        //    using (PersonContext CurrentContext = new PersonContext())
        //    {
        //        CurrentContext.Persons.Add(user);
        //        CurrentContext.SaveChanges();
        //    }
        //}

        public List<Person> GetPersons(string searchText)
        {
            List<Person> Persons = new List<Person>();
            using (var db = new PersonContext())
            {
                Persons = db.Persons.AsEnumerable().Where(o => o.FirstName.ToUpper().Contains(searchText.ToUpper()) || o.LastName.ToUpper().Contains(searchText.ToUpper())).ToList();
            }
            return Persons;
        }
    }
}
