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
        private void populateTheArray(int[] primitiveArray, int tempNumber)
        {
            
                for (int n = 0; n < primitiveArray.Length; n++)
                {
                //create each element
                generateRamdomNumber();
                //add each element to the array
                primitiveArray[n] = tempNumber;
                }
        }
        private void generateRamdomNumber()
        {
            int tempNumber;
            Random random = new Random();

            tempNumber = random.Next(51);
        }
    }
}
