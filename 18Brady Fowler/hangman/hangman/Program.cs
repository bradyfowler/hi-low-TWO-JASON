using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcome message
            Console.WriteLine("welcome to hangman. ");

            string word = ChooseWord();             

            
        }


        static string ChooseWord()
        {
            // choose a word
            Random rng = new Random();
            List<string> wordlist = new List<string>() { "explore", "burger", "senior", "september", "analyze", "magnified" };
            return wordlist[rng.Next(0, wordlist.Count)];
        }
    }
}
