﻿using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            

           
             
            for (i = 1; i <= 100; i++)

            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("This is fizz buzz" + i);

                }
                else if (i % 3 == 0) 
                {
                    Console.WriteLine("This is fizz" + i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("This is buzz"+ i);
                }
                else
                {
                    Console.WriteLine(i);

                }

                Console.ReadLine();
            }


        }
    }
}


