using System;
using System.IO;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Please enter your first name");          // Prompt user to enter their first name            
            string date = DateTime.Today.ToShortDateString();           // Get current date in short date format (MM/dd/yyyy)            
            string uName = Console.ReadLine();                          // Read user's input for first name            
            string msg = $"\nWelcome back {uName}. Today is {date}.";   // Create welcome message using user's name and current date            
            Console.WriteLine(msg);                                     // Display welcome message

            // Define the path to the text file containing student scores
            string path = @"C:\Users\jason\OneDrive\Desktop\C#_ASP.NET_Core_Scores\Scores\Scores\studentScores.txt";            
            string[] lines = File.ReadAllLines(path);                   // Read all lines from specified text file into array of strings

            double tScore = 0.0;
            
            Console.WriteLine("\nStudent Scores:  \n");                 // Display header for the list of student scores            
            foreach (string line in lines)                              // Loop through each line in file
            {                
                Console.Write("\n" + line);                             // Display current score                
                double score = Convert.ToDouble(line);                  // Convert line (score) to double                
                tScore += score;                                        // Add score to tScore (total score)
            }
            
            double avgScore = tScore / lines.Length;                    // Calculate average score
           
            Console.WriteLine("\nTotal of " + lines.Length +            // Display total number of student scores and average score
                              " student scores. " + "\t Average score: " + avgScore);            
            Console.WriteLine("\n\nPress any key to exit.");            // Prompt user to press any key to exit            
            Console.ReadKey();                                          // Wait for a key press before exiting
        }
    }
}