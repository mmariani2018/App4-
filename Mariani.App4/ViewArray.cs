﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App4
{
    class ViewArray
    {
        public ViewArray(Primitives[] primitiveArray)
        {
            showArray(primitiveArray);
        }

        private void showArray(Primitives[] primitiveArray)
        {
            string outputString = "";
            for(int n = 0; n < primitiveArray.Length; n++)
            {
                //outputString += primitiveArray[n].getNumbers;
            }
            Console.WriteLine(outputString);
        }

    }
}
