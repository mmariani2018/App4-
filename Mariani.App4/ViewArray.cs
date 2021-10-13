using System;
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
            InputOutput io = new InputOutput();
            String outputString = "";

            for (int n = 0; n < primitiveArray.Length; n++)
            {
                outputString += primitiveArray[n].getNumbers() + "\n";
            }

            io.showMessage("\nthe elements in this array are:\n" + outputString);
        }

    }
}
