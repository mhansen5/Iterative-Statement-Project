using System;

namespace Iterative_Statement_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 2 and 10 : ");

            int num;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch(System.FormatException)
            {
                Console.WriteLine(" Enter a valid integer.");
                return;
            }
            if (num % 2 == 0)
            {
                num++;

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("You entered an even number");
                }
            }
            else
            {
                num--;
                for(int i = 0; i < num; i ++ )
                {
                    Console.WriteLine("You entered an odd number");
                }
            }
            }
        }
    }

