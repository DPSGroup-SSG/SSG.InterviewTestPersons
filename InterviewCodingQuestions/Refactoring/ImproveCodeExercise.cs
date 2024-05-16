using System.Collections.Generic;
using System.Linq;

namespace InterviewCoding.Refactoring
{
    internal class ImproveCodeExercise
    {
        private readonly PersonContext _personContext;
        public ImproveCodeExercise()
        {
            _personContext = new PersonContext();
        }

        public List<Person> GetPeopleOver(int age, int numberOfRecords)
        {
            Person[] people = new Person[10];
            for (var i = 0; i < numberOfRecords; i++)
            {
                var person = _personContext.Persons.SingleOrDefault(x => x.Age > age);
                people[i] = person;
            }

            return people.ToList();
        }

        public List<Town> GetAllPeoplesTowns()
        {
            List<Town> towns = new List<Town>();
            var people = _personContext.Persons;
            foreach (var person in people)
            {
                var addressList = _personContext.Addresses.Where(x => x.Id == person.AddressId);
                foreach (var address in addressList)
                {
                    var townList = _personContext.Towns.Where(x => x.Country == address.Country);
                    towns.AddRange(townList);
                }
            }

            return towns;
        }
    }
}
