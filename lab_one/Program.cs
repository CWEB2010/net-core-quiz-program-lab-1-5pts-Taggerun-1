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
            string[] userChoice = new string[0];
            string userSelection;
            string[] questions = { "1) When was the latest version of .NET Core released?", "2) What makes .NET Core different from .NET Framework?",
            "3) What languages does .NET Core support?", "4) Who develops and supports .NET Core?", "5) What is the next major version of .NET Core coming in 2020?",
            "6) What is the name of .NET Core changing to in mid 2020?"};
            
            string[ , ] optionChoices = { 
                                {"A) December 31st, 2019", "B) December 3rd, 2019", "C) January 14th, 2020", "D) October 23rd, 2019"}, 
                                {"A) It is more functional than .NET Core.","B) .NET Core is a cross platform framework, .NET Framework is not.",
                                "C) It is newer than .NET Framework.", "D) .NET Framework does not recieve support anymore."},
                                {"A) C++, Java, and HTML", "B) C++, F#, and BASIC", "C) C#, F#, and Visual Basic", "D) C#, F++, and Visual Basic"},
                                {"A) Microsoft", "B) Apple", "C) Google", "D) Red Hat"},
                                {"A) 4.0", "B) 4.5", "C) 3.5", "D) 5.0" },
                                {"A) .NET Framework and Core", "B) Microsoft Core", "C) Windows Core", "D) .NET 5" }
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