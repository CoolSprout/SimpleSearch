using MySearchApp.Models.Entities;
using System.Collections.Generic;

namespace SimpleSearch.Models
{
    public interface IPersonRepository
    {
        //void AddPerson(Person user);
        List<Person> GetPersons(string searchText);
    }
}
