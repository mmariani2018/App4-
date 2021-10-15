using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mariani.App4
{
    class ArrayOfPrimitives
    {
        public ArrayOfPrimitives()
        {
            int[] numbers = CreateTheArray();
            int tempNumber = generateNumber(); 
            compareNumberToElements(tempNumber, numbers);
            showArray(numbers);
            
        }
        public int[] CreateTheArray()
        {
           return new int[50];      
        }
        public int generateNumber()
        {
            Random rnd = new Random();
            int tempNmber = rnd.Next(0, 50);

            return tempNmber;
        }
        public void compareNumberToElements(int tempNumber, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = tempNumber;

                //compare tempNumber to see if it is in array already
                if (numbers.Contains(tempNumber))
                {
                    generateNumber();
                }
                else
                {
                    for (int n = 0; n < numbers.Length; n++)
                    {
                        numbers[n] = tempNumber;
                    }
                }
            }
            //populate array if number is new
        }
        public void showArray(int [] numbers)
        {
            //numbers.int.Parse(Console.ReadLine());
            
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }





    }
}
