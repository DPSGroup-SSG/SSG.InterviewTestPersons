using System.Collections.Generic;


namespace InterviewCoding
{
    public class PersonContext
    {
        private List<Person> _persons;
        private List<Address> _addresses;
        private List<Town> _towns;

        public List<Person> Persons
        {
            get { return _persons; }
        }
        public List<Address> Addresses
        {
            get { return _addresses; }
        }
        public List<Town> Towns
        {
            get { return _towns; }
        }

        public PersonContext()
        {
            _persons = new List<Person>()
            {
                new Person { FirstName = "Frank", LastName = "Murphy", Age = 30, AddressId = 1},
                new Person { FirstName = "Mary", LastName = "Murphy", Age = 33, AddressId = 1},
                new Person { FirstName = "Rishi", LastName = "Sunak", Age = 44, AddressId = 6},
                new Person { FirstName = "Luka", LastName = "Modrić", Age = 38, AddressId = 3},
                new Person { FirstName = "Mickey", LastName = "Mouse", Age = 96, AddressId = 4},
                new Person { FirstName = "John", LastName = "Doe", Age = 24},
                new Person { FirstName = "Mary", LastName = "Jane", Age = 31}
            };

            _addresses = new List<Address>()
            {
                new Address() { AddressLine = "1 Dublin Ave", Country = Country.Ireland, Id = 1 },
                new Address() { AddressLine = "2 Dublin Ave", Country = Country.Ireland, Id = 2 },
                new Address() { AddressLine = "1 Gran Via Madrid", Country = Country.Spain, Id = 3 },
                new Address() { AddressLine = "1 Disneyland Paris", Country = Country.France, Id = 4 },
                new Address() { AddressLine = "1 Lake Garda", Country = Country.Italy, Id = 5 },
                new Address() { AddressLine = "10 Downing Street", Country = Country.England, Id = 6 }
            };

            _towns = new List<Town>()
            {
                new Town() { Name = "Dublin", Country = Country.Ireland  },
                new Town() { Name = "Carlow", Country = Country.Ireland  },
                new Town() { Name = "Barcelona", Country = Country.Spain },
                new Town() { Name = "Paris", Country = Country.France },
                new Town() { Name = "Rome", Country = Country.Italy},
                new Town() { Name = "London", Country = Country.England}
            };
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int? AddressId { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }
        public Country Country { get; set; }
    }
    public class Town
    {
        public string Name { get; set; }
        public Country Country { get; set; }
    }

    public enum Country
    {
        Ireland = 0,
        England = 1,
        France = 2,
        Spain = 3,
        Italy = 4
    }
}
