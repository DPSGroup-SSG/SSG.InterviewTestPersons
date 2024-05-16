using System;
using System.IO;


namespace InterviewCoding.Questions
{
    public class PersonLogger
    {
        private readonly PersonService _personService;
        public PersonLogger()
        {
            _personService = new PersonService();
        }


        public void WriteToFile(string fullFileName)
        {
            foreach (var person in _personService.GetAll())
            {
                var fullName = $"{person.FirstName} {person.LastName}";
                File.AppendAllText(fullFileName, fullName + Environment.NewLine);
            }
        }
    }
}