using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {

        //print the even-indexed and odd-indexed characters as 2 space-separated strings on a single line
        /*Sample Input:
        *    2
        *    Hacker
        *    Rank
        *
        * Sample Output:
        *    Hce akr
        *    Rn ak
        */
        
        int number_testCases= int.Parse(Console.ReadLine());
        
        int count=0;
        while(count<number_testCases)
        {
            string input = Console.ReadLine();
            
            int lenghtOfInput = input.Length;
            char[] characters = input.ToCharArray();
            
            for(int i=0; i<lenghtOfInput; i+=2)
            {
                Console.Write(characters[i]);
            }
            Console.Write("  ");
            
            for(int i=1; i<lenghtOfInput; i+=2)
            {
                Console.Write(characters[i]);
            }
            Console.WriteLine();
            
            count++;
        }
        

    }
}
