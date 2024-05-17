using System;

/*

Complete the method GetPeopleOrderedByAge(bool descending) in PersonService. It should return an IEnumerable<Person> ordered by age ascending
Write each name on a new line in the console. $"{FirstName} {LastName}" 
--

Create a method in the Question4 class that will take in the list of Persons ordered by age ascending and return the list of Persons ordered by age descending.
Write each name on a new line in the console. $"{FirstName} {LastName} {Age}" 

--

The Console.WriteLine can also be moved to it's own method and called. 
Write a method that handles the console log to screen

*/

namespace InterviewCoding.Questions
{
    public class Question4
    {
        private readonly PersonService _personService;
        public Question4()
        {
            _personService = new PersonService();
        }
        public void Solution()
        {

        }
    }
}