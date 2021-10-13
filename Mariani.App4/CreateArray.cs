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
            Primitives temp;
            

                for (int n = 0; n < primitiveArray.Length; n++)
                {
                //create each element
                CreateAndPopulate cpn = new CreateAndPopulate();
                temp = cpn.getGeneratedNumber();
                //add each element to the array
                primitiveArray[n] = temp;
                

                }
            
            
        }
    }
}
