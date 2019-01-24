/*
    Author: Matthew Bredahl
    Date: 01/20/2019
    Comments: This C# Console application code demonstrates the use of
              iterative statements after getting input from users. 
*/
using System;

namespace Deliverable2Iterative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer value between 1 and 100: ");

            string input = Console.ReadLine();

            try
            {
                int num = int.Parse(input);
                if (num > 0 && num <= 100)
                {
                    int counter = 1;
                    while (num != (counter - 1))
                    {
                        Console.WriteLine("You have entered " + num + ". This is the current integer value in the loop: " + counter);
                        counter++;

                        //Pauses program for .5 seconds, so the user isn't bombarded with line entries all at once
                        System.Threading.Thread.Sleep(500);

                    }//End while loop

                    //Prompts for user to close program manually    
                    Console.WriteLine("Press any key to continue . . . ");
                    Console.ReadKey(true);
                }//End if statement
                else
                {
                    Console.WriteLine("Verify your input and try again");
                    Console.WriteLine("Press any key to continue . . . ");
                    Console.ReadKey(true);
                }

            }//End try
            catch
            {
                //Displays ambigous statement in case of any possible errors that could occur
                Console.WriteLine("An error has occured");
                //Prompts for user to close program manually
                Console.WriteLine("Press any key to continue . . . ");
                Console.ReadKey(true);
        }//End catch
        }//End Main method
    }//End Program class
}//End namespace
