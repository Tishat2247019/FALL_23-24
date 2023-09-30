using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03
{
    internal class Problem_03
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {

                for (int b = 1; b <= 5 - i; b++)
                {
                       Console.Write("       ");
                }

                for (int j = 1; j <= (2 * i - 1); j++)
                {

                      Console.Write("*      ");
                   }  
             Console.WriteLine();
            }
       
            for (int i = 1; i <= 5 - 1; i++)
            {
                for (int b = 1; b <= i; b++)
                {
                    Console.Write("       ");
                   }
                for (int j = 1; j <= 2 * (5 - i) - 1; j++)
                { 
                    Console.Write("*      ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
