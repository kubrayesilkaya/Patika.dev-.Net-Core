using System;

namespace Algoritma_Sorular_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a positive number : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter " + n + "positive numbers");

            int[] numbers = new int[n];
            int count=0; // number of the even numbers

            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Please enter the " + (i+1) + ".number");
                numbers[i] = int.Parse(Console.ReadLine());
                if(numbers[i] % 2 == 0)
                {
                    count++;
                }
            }

            int[] evenNumbers = new int[count];
            int evenIndex = 0;
            for(int i=0; i<n; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    evenNumbers[evenIndex] = numbers[i];
                    evenIndex++;
                }
            }

            Console.WriteLine("The even ones of the numbers that you entered : ");
            foreach(int evenNumber in evenNumbers)
            {
                Console.Write(evenNumber + ",");
            }

            //*****************************************************************************************//
            // second version

            Console.WriteLine();

            Console.WriteLine("Please enter the size of your number array : ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] numberArray = new int[sizeOfArray];

            for(int i=0; i<sizeOfArray; i++)
            {
                Console.WriteLine("Please enter the {0}. number for your array :  ", i+1);
                numberArray[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<sizeOfArray; i++)
            {
                if(numberArray[i] % 2 == 0)
                {
                    Console.WriteLine("Even numbers from the array that you created is : " + numberArray[i]);
                }
            }
           
            
        }
    }
}