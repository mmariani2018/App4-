using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App4
{
    class CreateArray
    {
        public CreateArray()
        {
            int[] primitiveArray = createTheArray();
            populateTheArray(primitiveArray);
            showTheArrray(primitiveArray);

        }
        private void showTheArrray(int[] primitiveArray)
        {
            ViewArray view = new ViewArray(primitiveArray);
        }
        private int[] createTheArray()
        {
            return new int[50];
        }
        private void populateTheArray(int[] primitiveArray)
        {
            //generate a number
            //if generated nuber is in array generate new number
            //add number to array
                for (int n = 0; n < primitiveArray.Length; n++)
                {
                primitiveArray[n] = generateRamdomNumber(); 
                }
        }
        private int generateRamdomNumber()
        {
            int tempNumber;
            Random random = new Random();

            return tempNumber = random.Next(51);
        }
    }
}
