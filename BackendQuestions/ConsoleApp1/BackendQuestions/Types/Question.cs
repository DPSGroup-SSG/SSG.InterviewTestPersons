using BackendQuestions.Types.Data;

namespace BackendQuestions.Types
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
            //1 Please make the Dog and Cat Models implement INames and IAnimal interfaces
            //and AnimalAgility Model Implement the IAgility Interface


            //2 Create an abstract method in AgilityCalculator called TravelTime that accepts 2 params and returns an Int
            //A Type T where T is an IAgility
            //An Int Distance

            //3 Create a class that implements the Abstract class AgilityCalculator
            //simple calculation: return distance / agility.RunSpeed;

            //4 Have Cat and Dog Implement the new Class from step 3
            //should be able to call method like so: dog.TravelTime(dogAgility, 50);

            //5 Have the Cat model Override your method from step 3 and do addition calculation,
            //get the result from the calculation in your step 3 method then add the cats NapTimeLength to it as the new answer
            //return timeTraveled + NapTimeLength;




            //Test Result
            //var cat = animalRepository.Cats.FirstOrDefault();
            //var dog = animalRepository.Dogs.FirstOrDefault();
            //var agilityStats = animalRepository.AgilityStats;
            //var dogAgility = agilityStats.FirstOrDefault(A => A.TagNumber == dog.TagNumber);
            //var catAgility = agilityStats.FirstOrDefault(A => A.TagNumber == cat.TagNumber);

            //var timeToTravel = dog.TravelTime(dogAgility, 50); 
            //var timeToTravel = cat.TravelTime(catAgility, 50);

        }
    }
}