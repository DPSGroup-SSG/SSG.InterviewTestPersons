using System;


/*

Prerequesite: Must have completed GetAll function in the PersonService (part of Question 1)

What is an Extension Method?
Create an Extension Method called Reverse to reverse the Full Name strings on line 29 below.
Uncommment line 30 and display the output after completing the Reverse extension method

*/

namespace InterviewCoding.Questions
{
    public class Question7
    {
        private readonly PersonService _personService;
        public Question7()
        {
            _personService = new PersonService();
        }
        public void Solution()
        {
            var allPeople = _personService.GetAll();

            foreach (var person in allPeople)
            {
                var fullName = $"{person.FirstName} {person.LastName}";
                Console.WriteLine(fullName.Reverse());
            }
        }
    }
}