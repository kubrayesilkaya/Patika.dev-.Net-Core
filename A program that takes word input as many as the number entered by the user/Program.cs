using System;

namespace A_program_that_takes_word_input_as_many_as_the_number_entered_by_the_user
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of the word inputs that you will enter : ");
            int n = int.Parse(Console.ReadLine());

            string[] arrayWords = new string[n];

            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Please enter {0}.word",i+1);
                arrayWords[i] = Console.ReadLine();
            }

            Console.WriteLine("The word inputs that are entered : ");

            foreach ( string word in arrayWords)
            {
                Console.Write(word + " ");
            } 
        }
    }
}
