using System;

namespace Treehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------VALIDATION AND EXCEPTIONS PRACTICE-------------
            //TODO Switch to using "continue" and "break" to control the flow of execution through the program

            //bool keepGoing = true;

            while (true)
            {
                //TODO Update the text "Enter a number: " to "Enter a number between 1 and 1000: ".
                Console.Write("Enter a number between 1 and 1000: ");
                string userInput = Console.ReadLine();

                //TODO Force the user's provided value for the variable to lowercase so the user can type the text "quit" in any of the possible formats
                if (userInput.ToLower() == "quit")
                {
                    //keepGoing = false;
                    break;
                }
                //else

                //TODO Add a try/catch statement to catch FormatException exceptions. Handle exceptions by displaying "userInput + is not a number!"
                try
                {


                    //TODO Allow the user to enter a fractional value
                    var number = double.Parse(userInput);

                    //TODO If user enters a value <= 0 display "Please enter a number greater than 0"

                    //TODO If user enters a value > 1000 display "Please enter a number <= 1000"

                    var result = number * number;
                    Console.WriteLine($"{number} multiplied by itself is equals to {result}.");

                }
                catch
                {
                    Console.WriteLine($"{userInput} is not a number!");
                }
            }
            Console.WriteLine("K, bye");
            Console.Read();

            //--------------FITNESS FROG APP----------------------
            //double runningTotal = 0;
            //string msgOne = "Is that really all you've got? Just Saying...";
            //string msgTwo = "Well done good and faithfull servant...";
            //string msgThree = "You's a BAMF!!!";

            //while (true)
            //{
            //    Console.Write("Enter the number of minutes you exercise or type 'quit' to exit: ");
            //    var userInput = Console.ReadLine();
            //    if (userInput.ToLower() == "quit")
            //    {
            //        break;
            //    }

            //    try
            //    {
            //        var minutes = double.Parse(userInput);
            //        if (minutes <= 0)
            //        {
            //            Console.WriteLine("That is not a valid entry.");
            //            continue;
            //        }
            //        else if (minutes <= 30)
            //        {
            //            Console.WriteLine(msgOne);
            //        }
            //        else if (minutes < 60)
            //        {
            //            Console.WriteLine(msgTwo);
            //        }
            //        else
            //        {
            //            Console.WriteLine(msgThree);
            //        }
            //        runningTotal += minutes;
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("That is not a valid entry.");
            //        continue;
            //    }

            //    Console.WriteLine($"Ok, that makes {runningTotal} total minutes.");
            //    Console.WriteLine("");


            //}
            //Console.WriteLine("K, bye");

            //Console.Read();

            //---------------LOOPS AND CONDITIONALS------------ 
            //bool keepGoing = true;

            //while (keepGoing)
            //{
            //    Console.Write("Enter a number or 'quit': ");
            //    string userInput = Console.ReadLine();
            //    if (userInput == "quit")
            //    {
            //        keepGoing = false;
            //        break;
            //    }
            //    int toNum = int.Parse(userInput);
            //    int getSquare = toNum * toNum;
            //    Console.WriteLine($"The square of {toNum} is {getSquare}");
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("K, bye");
            //Console.Read();
        }
    }
}

