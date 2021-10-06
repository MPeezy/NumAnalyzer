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
            bool goAgain = true;

            while (goAgain == true)
            {


                Console.WriteLine("Please enter your name: ");
                Console.WriteLine();
                string inputName = Console.ReadLine();
                Console.WriteLine();


                Console.WriteLine("Hello " + inputName + "! Enter a number between 1 and 100: ");
                Console.WriteLine();

                int inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber % 2 == 1)
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


                else if (inputNumber % 2 == 1 && inputNumber > 60)

                {
                    Console.WriteLine();
                    Console.WriteLine(inputNumber + " Odd");
                    Console.WriteLine();

                }

                else if (inputNumber < 1)

                {
                    Console.WriteLine();
                    Console.WriteLine(inputNumber + " Invalid entry. Please enter a number between 1 and 100 " + inputName + "!");
                    Console.WriteLine();

                }

                else if (inputNumber > 100)

                {
                    Console.WriteLine();
                    Console.WriteLine(inputNumber + " Invalid entry. Please enter a number between 1 and 100 " + inputName + "!");
                    Console.WriteLine();

                }

                //*****CANT GET LOOP TO EXECUTE. NEED CLARIFICATION***

                //bool goAgain = true;
                //while (goAgain == true)

                //{
                //    Console.WriteLine("Continue? y/n");
                //    string answer = Console.ReadLine().ToLower();


                //    if (answer == "y")
                //    {
                //        //askToGoAgain = false;
                //        goAgain = true;
                //    }
                //    else if (answer == "n")
                //    {
                //        //askToGoAgain = false;
                //        goAgain = false;
                //        Console.WriteLine("Good Bye!");


                //    }




                //}
            }
        }
    }
}