using System;
using System.Collections.Generic;
using System.Linq;


namespace InterviewCoding
{
    public class PersonRepository
    {
        PersonContext personContext;
        public PersonRepository()
        {
            personContext = new PersonContext();
        }

        public IEnumerable<Person> GetAll()
        {
            return null;
        }

        public IEnumerable<Person> GetPeopleOlderThanAge(int age)
        {
            return null;
        }

        public IEnumerable<Person> GetPeopleByLastName(string lastName)
        {
            return null;
        }

        public IEnumerable<Person> GetPeopleOrderedByAge(bool descending)
        {
            return null;
        }

        public IEnumerable<string> GetAllPeopleWithAddresses()
        {
            return null;
        }

        public IEnumerable<string> GetPeopleByCountry(Country country)
        {
            return null;
        }
    }
}
