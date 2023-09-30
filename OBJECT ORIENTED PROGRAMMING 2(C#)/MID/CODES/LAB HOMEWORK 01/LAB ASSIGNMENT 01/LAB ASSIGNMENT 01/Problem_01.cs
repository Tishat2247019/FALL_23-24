using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ASSIGNMENT_01
{
    internal class Problem_01
    {
        static void Main(string[] args)
        {
            string digit_vowel = "0123456789aeiou";
            // string vowel = "aeiou";
            Console.WriteLine("Please enter a character to check wether it is a digit , or a vowel or any other character");
            char c = Convert.ToChar(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < digit_vowel.Length; i++)
            {
                if (c == digit_vowel[i] && i <= 9)
                {
                    Console.Write("This is a digit");
                    flag = true;
                    break;
                }
                else if (c == digit_vowel[i] && i >= 10)
                {
                    Console.WriteLine("THis is a vowel");
                    flag = true;
                    break;
                }
                
            }
            if (!flag)
            {
                Console.WriteLine("You entered any other symbol");
            }
            Console.ReadLine();
        }
    }
}
