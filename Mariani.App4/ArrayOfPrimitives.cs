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
            //populate first element in array with tempNumber
            //generate new number
            //compare tempNumber to see if it is in array already
            //populate array if number is new
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[0] = tempNumber;
                generateNumber();
                if (numbers.Contains(tempNumber))
                {
                    generateNumber();
                    numbers[i] = tempNumber;
                }
                else
                {
                    numbers[i] = tempNumber;
                }

            }
            


 
            
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
