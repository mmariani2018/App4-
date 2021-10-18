using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App4
{
    class CreateArray
    {
        
        public CreateArray()
        {

            Primitives[] primitiveArray = createTheArray();
            populateTheArray(primitiveArray);
            showTheArray(primitiveArray);

        } 
        private void showTheArray(Primitives[] primitiveArray)
        {
            ViewArray view = new ViewArray(primitiveArray);
        }
        private Primitives[] createTheArray()
        {
            return new Primitives[50];
        }
        private void populateTheArray(Primitives[] primitiveArray)
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
