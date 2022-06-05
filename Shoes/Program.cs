using System;
using System.Collections.Generic;

namespace Rosi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                int friends = int.Parse(input[0]);

                int chefShoes = int.Parse(input[1]);

                int neededShoes = 0;
                if (chefShoes > friends)
                {
                    neededShoes = friends;
                }
                else if (chefShoes < friends)
                {
                    neededShoes = friends + friends - chefShoes;
                }
                else
                {
                    neededShoes = friends;
                }

                Console.WriteLine(neededShoes);





            }
        }
    }
}