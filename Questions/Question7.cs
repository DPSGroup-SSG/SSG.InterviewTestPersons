using System;
using System.Linq;


/*

Prerequesite: Must have completed GetAll function in the PersonRepository (part of Question 1)

What is an Extension Method?
Create an Extension Method called Reverse to reverse the Full Name strings on line 30 below.
When complete, uncommment line 31 below and display the reverse name output.

*/

namespace InterviewCoding.Questions
{
    public class Question7
    {
        private readonly PersonRepository _personRepository;
        public Question7()
        {
            _personRepository = new PersonRepository();
        }
        public void Solution()
        {
            var allPeople = _personRepository.GetAll();

            foreach (var person in allPeople)
            {
                var fullName = $"{person.FirstName} {person.LastName}";
                //Console.WriteLine(fullName.Reverse());
            }
        }
    }
}