using System;

namespace CircusTreinBusiness
{
    public class Animal
    {
        public Animal(string animalName, spaceUsed animalSize, foodType animalDiet)
        {
            name = animalName;
            size = animalSize;
            diet = animalDiet;
        }
        public spaceUsed size { get; set; }

        public string name { get; set; }

        public foodType diet { get; set; }
    }
}
