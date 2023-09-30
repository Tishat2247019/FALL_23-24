using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02
{
    internal class Problem_02
    {
        static void convert_toBinary(int a)
        {
            int[] arr = new int[32];
            int i = 0; int num = a;
            while (a != 0)
            {
                arr[i] = a % 2;
                i++;
                a = a / 2;

            }
            Console.Write("Binary of " + num + " is : ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Please enter a decimal number to convert it to binary number");
            int n =  Convert.ToInt32(Console.ReadLine());
            convert_toBinary(n);
            Console.ReadLine();
         
        }
    }
}
