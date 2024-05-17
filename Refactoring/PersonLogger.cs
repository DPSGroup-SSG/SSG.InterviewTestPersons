using System;
using System.IO;


namespace InterviewCoding.Questions
{
    public class PersonLogger
    {
        private readonly PersonRepository _personRepository;
        public PersonLogger()
        {
            _personRepository = new PersonRepository();
        }


        public void WriteToFile(string fullFileName)
        {
            foreach (var person in _personRepository.GetAll())
            {
                var fullName = $"{person.FirstName} {person.LastName}";
                File.AppendAllText(fullFileName, fullName + Environment.NewLine);
            }
        }
    }
}