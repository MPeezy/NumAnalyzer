/*Number Analyzer-Decision Maker Lab #2 Grand Circus
**Marjorie Patton**

How can if statements be used to cover multiple situations? 
If statements can be used to cover multiple situations because they work with multiple data types. They use the conditions
set and check code from top to bottom until a true condition is found. If the condition is true then the code block will be executed. If 
the condition isn't true the if statement will move on until a true is found. An example is the code below. It checks multiple conditions
set and when the condition is found true the instrutions in that code block will run.
*/


using System;

namespace NumAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name: ");
            Console.WriteLine();
            string inputName = Console.ReadLine();
            Console.WriteLine();

            bool goAgain = true;

            while (goAgain == true)
            {

                Console.WriteLine("Hello " + inputName + "! Enter a number between 1 and 100: ");
                Console.WriteLine();

                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber < 1 || inputNumber > 100)

                    {
                        Console.WriteLine();
                        Console.WriteLine(inputNumber + " Invalid entry. Please enter a number between 1 and 100 " + inputName + "!");
                        Console.WriteLine();

                    }


                else if (inputNumber % 2 == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine(inputNumber + " and Odd");
                    Console.WriteLine();

                }
                else if (inputNumber % 2 == 0 && inputNumber > 1 && inputNumber < 26)

                {
                    Console.WriteLine();
                    Console.WriteLine(inputNumber + " Even and less than 25");
                    Console.WriteLine();

                }


                else if (inputNumber % 2 == 0 && inputNumber > 25 && inputNumber < 61)

                {
                    Console.WriteLine();
                    Console.WriteLine(inputNumber + " Even");
                    Console.WriteLine();

                }


                else if (inputNumber % 2 == 0 && inputNumber > 60)

                {
                    Console.WriteLine();
                    Console.WriteLine(inputNumber + " Even");
                    Console.WriteLine();

                }

                else if (inputNumber % 2 == 1 && inputNumber > 60)

                {
                    Console.WriteLine();
                    Console.WriteLine(inputNumber + " Odd");
                    Console.WriteLine();

                }

                

                bool askAgain = true;
                while (askAgain == true)
                {

                    Console.WriteLine();
                    Console.Write("Continue? (y/n): ");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "y")
                    {
                        askAgain = false;
                        goAgain = true;
                    }
                    else if (answer == "n")
                    {
                        askAgain = false;
                        goAgain = false;
                        Console.WriteLine("Good Bye!");
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry I didn't understand that ");
                        Console.WriteLine("Let's try that again");
                    }


                }
            }
        }
    }

}