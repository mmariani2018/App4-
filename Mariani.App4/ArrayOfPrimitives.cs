using System;
using System.Collections.Generic;
using System.Text;

namespace Mariani.App4
{
    class ArrayOfPrimitives
    {
        public ArrayOfPrimitives()
        {
            int[] numbers = new int[50];
            Console.WriteLine(generateRandomNumbersToAddToArray());

        }
        public int generateRandomNumbersToAddToArray()
        {
            Random randomNumber = new Random();
            int tempNumber;

            return tempNumber = randomNumber.Next(51);

        }
       

    }
}
