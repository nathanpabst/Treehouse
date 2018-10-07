using System;

namespace Treehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------FITNESS FROG APP----------------------
            double runningTotal = 0;
            string msgOne = "Is that really all you've got? Just Saying...";
            string msgTwo = "Well done good and faithfull servant...";
            string msgThree = "You's a BAMF!!!";

            while (true)
            {
                Console.Write("Enter the number of minutes you exercise or type 'quit' to exit: ");
                var userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                {
                    break;
                }

                try
                {
                    var minutes = double.Parse(userInput);
                    if (minutes <= 0)
                    {
                        Console.WriteLine("That is not a valid entry.");
                        continue;
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine(msgOne);
                    }
                    else if (minutes < 60)
                    {
                        Console.WriteLine(msgTwo);
                    }
                    else
                    {
                        Console.WriteLine(msgThree);
                    }
                    runningTotal += minutes;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid entry.");
                    continue;
                }

                Console.WriteLine($"Ok, that makes {runningTotal} total minutes.");
                Console.WriteLine("");


            }
            Console.WriteLine("K, bye");

            Console.Read();

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

