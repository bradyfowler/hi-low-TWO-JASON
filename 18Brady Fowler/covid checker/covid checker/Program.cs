using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the covid temperature checker");
            Console.WriteLine();

            while (true)
            {
                //
                double Temperature = InputDouble("What is your Temperature? ");
                Console.WriteLine();

                int symptom = 0;
                const double dangerhigh = 37.9;
                const double dangerlow = 35.1;

                if (Temperature > dangerhigh)
                {
                    symptom = symptom + 1;
                }

                else if (Temperature < dangerlow)
                {
                    symptom = symptom + 1;
                }

                else if (dangerlow < Temperature)
                {
                    Console.WriteLine("Your Temperature is fine");
                }
                //

                //
                Console.Write("Do you have a new, persistent dry cough?(y/n) ");
                while (true)
                {
                    string Cough = Console.ReadLine();
                    if (Cough = y)
                    {
                        symptom = symptom + 1;
                        break;
                    }
                    else if (Cough = n)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("invalid input");
                    }
                }
                //

                //
                Console.Write("Do you have an altered sense of taste/smell(y/n) ");
                while (true)
                {
                    string sense = Console.ReadLine();
                    if (sense = y)
                    {
                        symptom = symptom + 1;
                        break;
                    }
                    else if (sense = n);
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("invalid input");
                    }

                    if (symptom>0)
                    {
                        Console.Write("Please get a covid test");
                    }
                    else
                    {
                        Console.Write("You are fine, no need to isolate");
                    }
                }



                Console.WriteLine();
            }
        }


        static double InputDouble(String Prompt)
        {
            double number = 0.0;
            while (true)
            {
                try
                {
                    Console.Write(Prompt);
                    number = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                }
            }
            return number;
        }
    }


}
