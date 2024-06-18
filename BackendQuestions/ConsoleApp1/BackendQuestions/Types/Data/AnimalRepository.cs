using BackendQuestions.Types.Model;

namespace BackendQuestions.Types.Data
{
    public class AnimalRepository
    {
        private List<Cat> _cats;
        private List<Dog> _dogs;
        private List<AnimalAgility> _AgilityStats;

        public List<Cat> Cats
        {
            get { return _cats; }
        }
        public List<Dog> Dogs
        {
            get { return _dogs; }
        }
        public List<AnimalAgility> AgilityStats
        {
            get { return _AgilityStats; }
        }

        public AnimalRepository()
        {
            _cats = new List<Cat>()
            {
                //new Cat { FirstName = "Frank", LastName = "Murphy", NapTimeLength = 5, TagNumber = 1},
                //new Cat { FirstName = "Billy", LastName = "Murphy", NapTimeLength = 9, TagNumber = 2},
                //new Cat { FirstName = "Joe", LastName = "Murphy", NapTimeLength = 4, TagNumber = 3},
                //new Cat { FirstName = "John", LastName = "Murphy", NapTimeLength = 2, TagNumber = 4},
            };

            _dogs = new List<Dog>()
            {
                //new Dog { FirstName = "Frank", LastName = "Murphy", TagNumber = 5},
                //new Dog { FirstName = "Billy", LastName = "Murphy", TagNumber =6},
                //new Dog { FirstName = "Joe", LastName = "Murphy", TagNumber = 7},
                //new Dog { FirstName = "John", LastName = "Murphy", TagNumber = 8},
            };

            _AgilityStats = new List<AnimalAgility>()
            {
                //new AnimalAgility() { TagNumber = 1, RunSpeed = 5 },
                //new AnimalAgility() { TagNumber = 2, RunSpeed = 6 },
                //new AnimalAgility() { TagNumber = 3, RunSpeed = 8 },
                //new AnimalAgility() { TagNumber = 4, RunSpeed = 2 },
                //new AnimalAgility() { TagNumber = 5, RunSpeed = 4 },
                //new AnimalAgility() { TagNumber = 6, RunSpeed = 15 },
                //new AnimalAgility() { TagNumber = 7, RunSpeed = 7 },
                //new AnimalAgility() { TagNumber = 8, RunSpeed = 1 },
            };
        }
    }
    
}
