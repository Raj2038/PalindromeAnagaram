using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeAnagram
{
    class PalindromeAnagrm
    {

        static bool IsPalindrome(string src)
        {
            bool palindrome = true;
            for (int i = 0; i < src.Length / 2 + 1; i++)
            {
                if (src[i] != src[src.Length - i - 1])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;

        }

        static void Main(string[] args)
        {
            //To Check Palindrome

            //Receive Word from User  
            Console.Write("Enter a String: ");
            string s = Console.ReadLine();
            if (IsPalindrome(s) == true)
            {
                //Console.WriteLine(true);
                Console.WriteLine("Palindrome");
            }
            else
            {
                //Console.WriteLine(false);
                Console.WriteLine("Not Palindrome");
            }




            //To Check Anagram

            //Receive Word from User  
            Console.Write("Enter first word:" + s + "\n");
            string word1 = s;
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();


            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();


            Array.Sort(char1);
            Array.Sort(char2);


            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

            //ToLower allows to compare the words.  
            if (NewWord1 == NewWord2)
            {
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams\n", word1, word2);
            }
            else
            {
                Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
            }

            Console.ReadLine();


        }





    }

}

