using System;

namespace Program_that_calculates_the_number_of_words_and_letters_in_an_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentences : ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' '); // cümleyi boşluk karakterlerinden ayırıp words dizisine atıyorum.

            string spacelessSentence = sentence.Replace(" ",""); // boşluk karakterleini kaldırdım ve yeni değişkene atadım. 
            
            char[] letters = spacelessSentence.ToCharArray(); //yeni değişkendeki stringi karakter karakter diziye dönüştürdüm.

            int countWords = 0;
            int countLetters = 0;

            foreach(string word in words)
            {
                countWords ++;
            }
        
            foreach(char letter in spacelessSentence)
            {
                countLetters++;
            }

            Console.WriteLine("Number of words in your sentence : " + countWords);
            Console.WriteLine("Number of letters in your sentence :" + countLetters);


        }
    }
}