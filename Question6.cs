using System;

/*

Complete the method GetPeopleByCountry(Country country) in PersonService. It should return an IEnumerable<string> of only people from Ireland
Write each name on a new line in the console. $"{FirstName} {LastName}" 

*/

namespace InterviewCoding.Questions
{
    public class Question6
    {
        private readonly PersonService _personService;
        public Question6()
        {
            _personService = new PersonService();
        }
        public void Solution()
        {
            var peopleFromIreland = _personService.GetPeopleByCountry(Country.Ireland);

            foreach (var person in peopleFromIreland)
                Console.WriteLine($"{person}");
        }
    }
}