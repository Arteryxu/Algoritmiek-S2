using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinBusiness
{
    class Cart
    {
        //Animals are the animals in the cart
        List<Animal> Animals = new List<Animal>();
        private int maxSpace = 10;

        public Cart(int cartSpace)
        {
            maxSpace = cartSpace;
        }
        //animal is the animal being added
        private bool receiveAnimal(Animal animal)
        {
            //cartPoints is the used space
            int cartPoints = getPoints();
            //animalPoints is the points the new animal uses
            int animalPoints = animal.GetPoints();
            //To do add exception
            if (cartPoints == 0)
            {
                return true;
            }
            if (cartPoints + animalPoints > maxSpace)
            {
                return false;
            }
            if (animal.diet == foodType.Carnivore)
            {
                foreach(var oldAnimal in Animals)
                {
                    if (oldAnimal.size <= animal.size)
                    {
                        return false;
                    }
                }
            }

            if (animal.diet == foodType.Herbivore)
            {
                foreach(var oldAnimal in Animals)
                {
                    if (oldAnimal.size >= animal.size && oldAnimal.diet == foodType.Carnivore)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void addAnimal()
        {

        }
        
        public int getPoints()
        {
            int points = 0;
            foreach(Animal animal in Animals)
            {
                points += animal.GetPoints();
            }
            return points;
        }
    }
}
