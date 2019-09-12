/* 
    Author: Derrick Burns
    Date: 9/10/2019
    Description: This program will display a student's grades
*/
using System;

namespace Deliverable2_IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Enter an integer value between 0 and 100: \n");

            // Use try-catch block to validate user input
            try
            {
                // This variable will gather the user input
                string input = Console.ReadLine();

                /*
                    This variable will be used to store the number entered
                    after the input variable is parsed to int
                */
                int number = int.Parse(input);

                // Data validation
                if (number < 0 || number > 100)
                {
                    Console.WriteLine("\nInteger value must be between 0 and 100.");
                    return;
                }

                // Create a space
                Console.WriteLine("\n");

                // For loop to to display message for the amount of times equal to user's integer value
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine("You have entered " + number + ". This is the current integer value in the loop: " + i);
                }
            } // End of try
            catch
            {
                Console.WriteLine("\nPlease use an integer data type");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // End of catch
            
        }
    }
}
