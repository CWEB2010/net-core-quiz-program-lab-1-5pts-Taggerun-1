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

            string[] answerKey = {"B", "B", "C", "A", "D", "A", "A", "C", "D", "A"};
            string[] userChoice = new string[0];
            string userSelection;
            string[] questions = {"1) When was the latest version of .NET Core released?", "2) What makes .NET Core different from .NET Framework?",
                "3) What languages does .NET Core support?", "4) Who develops and supports .NET Core?", "5) What is the next major version of .NET Core coming in 2020?",
                "6) What is the name of .NET Core changing to in mid 2020?", "7) When was .NET Core released?", "8) What IDE allows you to create .NET Core applications?",
                "9) What is the most popular .NET language?","10) What Operating System(s) is .NET Core avaiable on?"};
            
            string[ , ] optionChoices = 
            { 
                {"A) December 31st, 2019", "B) December 3rd, 2019", "C) January 14th, 2020", "D) October 23rd, 2019"}, 
                {"A) It is more functional than .NET Core.","B) .NET Core is a cross platform framework, .NET Framework is not.",
                 "C) It is newer than .NET Framework.", "D) .NET Framework does not recieve support anymore."},
                {"A) C++, Java, and HTML", "B) C++, F#, and BASIC", "C) C#, F#, and Visual Basic", "D) C#, F++, and Visual Basic"},
                {"A) Microsoft", "B) Apple", "C) Google", "D) Red Hat"},
                {"A) 4.0", "B) 4.5", "C) 3.5", "D) 5.0" },
                {"A) .NET 5", "B) Microsoft .NET Core", "C) Windows Core", "D) .NET Framework and Core" },
                {"A) 6/27/2016", "B) 10/27/2002", "C) 5/16/2005", "D) 8/30/2000" },
                {"A) Visual Studio Code", "B) VS Code", "C) Visual Studio 2019", "D) XCode" },
                {"A) JavaScript", "B) F#", "C) Visual Basic .NET", "D) C#" },
                {"A) Mac OS, Windows, and Linux", "B) Mac OS X, Windows 10, and DOS", "C) iOS, Android, BlackBerry OS", "D) Windows 10 only" }
            };

            int primingValue;
            int EXIT = 2;
            int x;
            int y;
            int totalCorrect = 0;
            int totalIncorrect = 0;

            Console.WriteLine("Welcome to this quiz on .NET Core." + "\n" +
                "This quiz contains 10 questions." + "\n" +
                "You must obtain a 7 out of 10 to pass this quiz.");
            Console.WriteLine("To start the quiz please enter 1.");
            primingValue = Convert.ToInt32(Console.ReadKey());
            Console.Clear();

            while (primingValue != EXIT)
            { 
                for (x = 0; x < questions.Length; x++)
                {
                    Console.WriteLine(questions[x]);

                    for (y = 0; y < optionChoices.GetLength(1); y++)
                    {
                        Console.WriteLine(optionChoices[x, y]);
                    }

                    Console.WriteLine("Please enter your selection");
                    userSelection = Convert.ToString(Console.ReadKey());

                    if (userSelection == answerKey[x])
                    {
                        totalCorrect++;
                        Console.WriteLine("You got it right!");
                    }
                    
                    else
                    {
                        totalIncorrect++;
                        Console.WriteLine("You got it wrong.");
                    }

                    userChoice[x] = userSelection;
                }
            }
        }
    }
}