using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace high_low
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcome message

            Console.WriteLine("Welcome to the high low game ");

            int guesses = 0;

            //chooses numbers

            Random rng = new Random();
            int number = rng.Next(1, 11);

            while (true)
            {
                //enter user guess
                Console.Write("Enter Guess: ");

                int guess = Convert.ToInt32(Console.ReadLine());

                //compare guess to number

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                    guesses = guesses + 1;
                }

                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    guesses = guesses + 1;
                }

                else
                {
                    Console.WriteLine("Correct");
                    Console.WriteLine("You have guessed incorrectly " + guesses + " times. ");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
