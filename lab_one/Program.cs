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
            string[] userChoice = new string[10];
            string userSelection;
            string[] questions = 
                {
                "1) When was the latest version of .NET Core released?",
                "2) What makes .NET Core different from .NET Framework?",
                "3) What languages does .NET Core support?",
                "4) Who develops and supports .NET Core?",
                "5) What is the next major version of .NET Core coming in 2020?",
                "6) What is the name of .NET Core changing to in mid 2020?",
                "7) When was .NET Core released?",
                "8) What IDE allows you to create .NET Core applications?",
                "9) What is the most popular .NET Core language?",
                "10) What Operating System(s) is .NET Core avaiable on?"
            };
            
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

            // Initializing Variables
            string primingValue;
            
            // Sentinel Values
            string EXIT = "NumPad2";
            string EXIT2 = "D2";

            // Iterative Variables
            int x;
            int y;

            //Quiz Scores
            int score = 0; 
            
            //Score during the test
            int totalCorrect = 0;
            int totalIncorrect = 0;

            //Final quiz score
            int finalScore = 0;

            //Tells ths user what the quiz is about and how many questions they must get right to pass
            Console.WriteLine("Welcome to this quiz on .NET Core." + "\n" +
                "This quiz contains 10 questions." + "\n" +
                "You must obtain a 7 out of 10 to pass this quiz.");

            //Tells the user how to start the quiz
            Console.WriteLine("To start the quiz please press any key.");

            //Begins the quiz and removes console clutter
            primingValue = Console.ReadKey().Key.ToString();
            Console.WriteLine(primingValue);
            Console.Clear();

            //While that runs the program and runs through each question and answers for each question
            while (primingValue != EXIT)
            {
                //Iterates through each question
                for (x = 0; x < questions.GetLength(0); x++)
                {
                    Console.WriteLine(questions[x]);

                    //Iterates through the list of answers
                    for (y = 0; y < optionChoices.GetLength(1); y++)
                    {
                        Console.WriteLine(optionChoices[x, y]);
                    }

                    //Tells the user how to submit their answer and how to move on to each question
                    Console.WriteLine("\nPlease enter your selection:");
                    Console.WriteLine("\nPress the enter key after you answer each question to continue.");

                    //Reads the user's answer
                    userSelection = Console.ReadKey().Key.ToString();

                    //Checks the user answer to see if the answer is correct.
                    if (userSelection == answerKey[x] | userSelection == answerKey[x].ToLower())
                    {
                        totalCorrect++;
                        score++;
                        Console.WriteLine("\nYou got it right!");
                        Console.WriteLine("\nYour current score is " + score + " out of 10.");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    //Checks the user answer to see if the answer is incorrect.
                    if (userSelection != answerKey[x] && userSelection != answerKey[x].ToLower())
                    {
                        totalIncorrect++;
                        Console.WriteLine("\nYou got it wrong.");
                        Console.WriteLine("\nYour current score is " + score + " out of 10.");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    userChoice[x] = userSelection;
                }

                //Clears the console and gives the user their score
                Console.Clear();
                finalScore = 10 - totalIncorrect;
                Console.WriteLine("This quiz has concluded, your results are listed below.");
                Console.WriteLine("Total Correct: " + totalCorrect);
                Console.WriteLine("Total Incorrect: " + totalIncorrect);
                Console.WriteLine("Your final score is " + finalScore + " out of 10\n");
                
                //Tells the user they passed
                if (totalCorrect >= 7)
                {
                    Console.WriteLine("You passed this quiz!\n");
                }

                //Tells the user they failed
                else
                {
                    Console.WriteLine("Sorry you failed the quiz, please retake the quiz to pass.\n");
                }

                //Tells the user how to exit the computer
                Console.WriteLine("To retake the quiz, please press any key or enter 2 to exit the quiz.");

                //Resets the users quiz score and checks the users input to see if they want to take the test again or not
                primingValue = Console.ReadKey().Key.ToString();
                Console.WriteLine(primingValue);
                Console.Clear();
                x = 0;
                y = 0;
                score = 0;
                totalCorrect = 0;
                totalIncorrect = 0;
                finalScore = 0;

                //Checks the users input for the required exit value
                if (primingValue == EXIT | primingValue == EXIT2)
                {
                    break;
                }
            }

            //Says goodbye to the user and ends the program
            Console.Clear();
            Console.WriteLine("Thank you for taking my .NET Core quiz.");
            Console.WriteLine("Have a nice day!");
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}