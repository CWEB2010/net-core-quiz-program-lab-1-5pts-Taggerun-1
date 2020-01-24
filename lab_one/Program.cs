//Name: Christian Monroe

//Purpose: To create a quiz that tests the user knowledge of .NET Core

//Date Created: 1/24/2020

using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] answerKey = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };
            string[] userChoice = new string[4];
            string userSelection;
            string[] questions = { "When was the latest version of .NET Core released?", "What makes .NET Core different from .NET Framework?",
            ""};
            string[ , ] optionChoices = { 
                                {"A) December 31st, 2019", "B) December 3rd, 2019", "C) January 14th, 2020", "D) October 23rd, 2019"}, 
                                {"A) ","", "", ""} 
                                };

            int x;
            int y;

            Console.WriteLine("Welcome to this quiz on .NET Core." + "\n" +
                "This quiz contains 10 questions." + "\n" +
                "You must obtain a 7 out of 10 to pass this quiz.");
            Console.WriteLine();
            Console.Clear();

            for (x = 0; x < questions.Length; x++)
            {
                Console.WriteLine(questions[x]);
                for (y = 0; y < optionChoices.GetLength(1); y++)
                {
                    Console.WriteLine(optionChoices[x, y]);
                }
            }
        }
    }
}