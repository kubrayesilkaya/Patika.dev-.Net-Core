using System;

namespace Numbers_divisible_by_a_certain_number
{
    class Program
    {
        static void Main(string[] args)
        {

            // n -> number of numbers
            // m -> divison parameter

            Console.WriteLine("Please enter the number of numbers you will enter : ");
            int n = int.Parse(Console.ReadLine());
            
            int[] arrayOfNumbers = new int[n];

            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Please enter {0} numbers",n);
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter the divison parameter : ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers that are divisible or equal to {0} from among the numbers you enter :",m);

            foreach(int numbers in arrayOfNumbers)
            {
                if(numbers % m == 0 || numbers == m)
                {
                    Console.WriteLine(numbers);
                }
            }
        }
    }
}
