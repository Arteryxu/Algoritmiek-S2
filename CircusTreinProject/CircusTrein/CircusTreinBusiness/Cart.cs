using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTreinBusiness
{
    class Cart
    {

        public int remainingSpace = 10;

        public Cart(int cartSpace)
        {
            remainingSpace = cartSpace;
        }
        private void receiveAnimal()
        {
            int animalSize = 0;
            //To do add exception
            if (animalSize > remainingSpace)
            {

            }
            
        }

        private void addAnimal()
        {

        }
    }
}
