// The application allows the user to take a Quiz and displays a Progress Report.
// Author: Oscar Piederasanta Diaz 101061602
using System;
using System.Linq; // Provides a set of extension methods and query operators for querying and manipulating data in collections.

namespace assingment1
{
    class Quiz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quiz! Kindly review the instructions and proceed accordingly."); //Friendly greeting message from our program to the user.
            string confirmation = null; // Declaring confirmation 
            string[] yes = { "yes", "Yes", "y", "Y", "YES" }; // Using an array to check all variations of "yes" that the user can input.
            string[] no = { "no", "No", "n", "N", "NO" }; // Using an array to check all variations of "no" that the user can input.
            string fName = null; // fName = user first name
            string lName = null; // lName = user last name
            do // First do while loop to ensure that we run the below code at least once to get the user name.
            {
                Console.Write("\nPlease enter your first name: "); // \n allows us to create an extra line of space to make the quiz more user friendly on the eyes
                fName = Console.ReadLine();
                Console.Write("Please enter your last name: ");
                lName = Console.ReadLine(); 
                Console.WriteLine("Is your name " + fName + " " + lName + "?"); // Confirmation message to make sure user got his/her name correct so we don’t run into any issues when doing the progress report.

                do // Second do while loop is to confirm the user name in case they make a typo.
                {
                    Console.Write("Please confirm with yes or no: ");
                    confirmation = Console.ReadLine();
                    if (no.Contains(confirmation)) // Refers and checks the above array "no" to see if confirmation does = any of those variations of no
                    {
                        Console.WriteLine("Please re-enter your name");
                        continue;
                    }
                } while (!no.Contains(confirmation) && !yes.Contains(confirmation));  // Refers and checks the above array "no" & "yes" to see if confirmation does = any of those variations of no.
            } while (!yes.Contains(confirmation)); // While the user does not enter any varaiton of the yes array then loop if user enters yes then continue with quiz
            Console.WriteLine("Excellent lets continue with the quiz!");

            //Start of quiz & question 1
            string ans1 = null; // ans1 = answer 1 for question 1 
            string[] incAns1 = { "A", "a", "B", "b", "D", "d" }; // incAns1 = Incorrect Answer 1
            int counter1 = 1; // counter1 = counter for question 1
            int result1 = 0; // result1 = marks for question 1 
            do
            {
                Console.WriteLine("\nQuestion 1:");
                Console.WriteLine("Who won the World Cup in 2022?");
                Console.WriteLine("A: Germany");
                Console.WriteLine("B: Japan");
                Console.WriteLine("C: Argentina");
                Console.WriteLine("D: Canada");
                ans1 = Console.ReadLine();
                if (counter1 == 4) //&& ans1 != "C" && ans1 != "c")
                {
                    break; // We want the quiz to stop prompting question1 once the user gets to 4 attempts
                }
                if (counter1 <=3 && ans1 != "C" && ans1 != "c")
                {
                    Console.WriteLine("Thats incorrect please try again");
                    counter1++;
                }
            }
            while (ans1 != "C" && ans1 != "c");
            switch (counter1)
            {
                case 1:
                    Console.WriteLine("Congrats you're right!");
                    result1 = 20;
                    Console.WriteLine(result1 + "/20");
                    break;
                case 2:
                    Console.WriteLine("Congrats you're right!");
                    result1 = 10;
                    Console.WriteLine(result1 + "/20");
                    break;
                case 3:
                    Console.WriteLine("Congrats you're right!");
                    result1 = 5;
                    Console.WriteLine(result1 + "/20");
                    break;
                case 4 when ans1 != "C" && ans1 != "c":
                    Console.WriteLine("Incorrect.");
                    result1 = 0;
                    Console.WriteLine(result1 + "/20");
                    break;
                case 4:
                    Console.WriteLine("Max attempts reached");
                    result1 = 0;
                    Console.WriteLine(result1 + "/20");
                    break;
            }

            // Start of question 2
            string ans2 = null; // ans2 = answer 2 for question 2 
            string[] incAns2 = { "C", "c", "B", "b", "D", "d" }; // incAns2 = Incorrect Answer 2
            int counter2 = 1; // counter2 = counter for question 2
            int result2 = 0; // result2 = marks for question 2 
            do
            {
                Console.WriteLine("\nQuestion 2:");
                Console.WriteLine("Who won the NBA Finals 2023");
                Console.WriteLine("A: Denver Nuggets");
                Console.WriteLine("B: Los Angeles Lakers");
                Console.WriteLine("C: Miami Heat");
                Console.WriteLine("D: Los Angeles Clippers");
                ans2 = Console.ReadLine();
                if (counter2 == 4)
                {
                    break;
                }
                if (counter2 <= 3 && ans2 != "A" && ans2 != "a")
                {
                    Console.WriteLine("Thats incorrect please try again");
                    counter2++;
                }
            }
            while (ans2 != "A" && ans2 != "a");
            switch (counter2)
            {
                case 1:
                    Console.WriteLine("Congrats you're right!");
                    result2 = 20;
                    Console.WriteLine(result2 + "/20");
                    break;
                case 2:
                    Console.WriteLine("Congrats you're right!");
                    result2 = 10;
                    Console.WriteLine(result2 + "/20");
                    break;
                case 3:
                    Console.WriteLine("Congrats you're right!");
                    result2 = 5;
                    Console.WriteLine(result2 + "/20");
                    break;
                case 4 when ans2 != "A" && ans2 != "a":
                    Console.WriteLine("Incorrect.");
                    result2 = 0;
                    Console.WriteLine(result2 + "/20");
                    break;
                case 4:
                    Console.WriteLine("Max attempts reached");
                    result2 = 0;
                    Console.WriteLine(result2 + "/20");
                    break;
                default:
                    break;
            }

            // Start of question 3
            string ans3 = null; // ans3 = answer 3 for question 3 
            string[] incAns3 = { "C", "c", "B", "b", "D", "d" }; // incAns3 = Incorrect Answer for question 3
            int counter3 = 1; // counter3 = counter for question 3
            int result3 = 0; // result3 = marks for question 3 
            do
            {
                Console.WriteLine("\nQuestion 3:");
                Console.WriteLine("What is the biggest company in the world in terms of market cap");
                Console.WriteLine("A: Apple");
                Console.WriteLine("B: Tesla");
                Console.WriteLine("C: Microsoft");
                Console.WriteLine("D: Alphabet Inc.");
                ans3 = Console.ReadLine();
                if (counter3 == 4)
                {
                    break;
                }
                if (counter3 <= 3 && ans3 != "A" && ans3 != "a")
                {
                    Console.WriteLine("Thats incorrect please try again");
                    counter3++;
                }
            }
            while (ans3 != "A" && ans3 != "a");
            switch (counter3)
            {
                case 1:
                    Console.WriteLine("Congrats you're right!");
                    result3 = 20;
                    Console.WriteLine(result3 + "/20");
                    break;
                case 2:
                    Console.WriteLine("Congrats you're right!");
                    result3 = 10;
                    Console.WriteLine(result3 + "/20");
                    break;
                case 3:
                    Console.WriteLine("Congrats you're right!");
                    result3 = 5;
                    Console.WriteLine(result3 + "/20");
                    break;
                case 4 when ans3 != "A" && ans3 != "a":
                    Console.WriteLine("Incorrect.");
                    result3 = 0;
                    Console.WriteLine(result3 + "/20");
                    break;
                case 4:
                    Console.WriteLine("Max attempts reached");
                    result3 = 0;
                    Console.WriteLine(result3 + "/20");
                    break;
                default:
                    break;
            }

            // Start of Progress Report
            Console.WriteLine("\nProgress Report: " + fName + " " + lName); 
            Console.WriteLine(result1 + result2 + result3 + "/60"); // Calculating marks and diplaying out results out of 60.  
            Console.WriteLine((result1 + result2 + result3) * 100 / 60 + "%"); // Calculating marks and diplaying out results in a percentage format.
            Console.WriteLine("Number of attempts for question one: " + counter1);
            Console.WriteLine("Number of attempts for question two: " + counter2);
            Console.WriteLine("Number of attempts for question three: " + counter3);
        }

    }
}