using System.Linq;
using InterviewCoding.Types.Data;
using InterviewCoding.Types.Model;

namespace InterviewCoding.Types
{
    public class Question
    {
        AnimalRepository animalRepository;
        public Question()
        {
            animalRepository = new AnimalRepository();
        }
        public void Quesiton1()
        {
            //Please make the Dog, Cat and AnimalAgility Models implement their matching Interface's

            //Create an abstract definition of a method in AgilityCalculator called TravelTime that accepts 2 params
                    //A Type T where T is an IAgility
                    //An Int Distance

            //Create a class that can override your abstract method in AgilityCalculator
                    //return distance / agility.RunSpeed;

            //Have Cat and Dog be able to call your new AgilityCalculator class override method as an extension

            //Have the Cat model Override your method to use its additional information JumpDistance to speed up its TravelTime 
        }
    }
}