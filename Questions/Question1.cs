using System;
using System.IO;

/*

Q1 Complete the method GetAll in PersonRepository. It should return an IEnumerable<Person> which contains all Persons.
Write each name on a new line in the console. $"{FirstName} {LastName}" 
Write each name on a new line in a file called persons.txt. The file should be in the same directory as the executing program

*/

namespace InterviewCoding.Questions
{
    public class Question1
    {
        private readonly PersonRepository _personRepository;
        public Question1()
        {
            _personRepository = new PersonRepository();
        }
        public void Solution()
        {
            
        }
    }
}
