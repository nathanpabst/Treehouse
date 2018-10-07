using System;

namespace Treehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------FITNESS FROG APP----------------------
            int runningTotal = 0;
            bool keepGoing = true;
            string msgOne = "Is that really all you've got? Just Saying...";
            string msgTwo = "Well done good and faithfull servant...";
            string msgThree = "You's a BAMF!!!";

            while (keepGoing)
            {
                Console.Write("Enter the number of minutes you exercise or type 'quit' to exit: ");
                string userInput = Console.ReadLine();
                if (userInput == "quit")
                {
                    keepGoing = false;
                    break;
                }
                else
                {
                    int minutes = int.Parse(userInput);
                    if (minutes <= 30)
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

                    runningTotal = runningTotal + minutes;

                    Console.WriteLine($"Ok, that makes {runningTotal} total minutes.");
                    Console.WriteLine("");

                }
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

