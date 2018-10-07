using System;

namespace Treehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.Write("Enter a number or 'quit': ");
                string userInput = Console.ReadLine();
                if (userInput == "quit")
                {
                    keepGoing = false;
                    break;
                }
                int toNum = int.Parse(userInput);
                int getSquare = toNum * toNum;
                Console.WriteLine($"The square of {toNum} is {getSquare}");
                Console.WriteLine("");
            }

            Console.WriteLine("K, bye");
            Console.Read();
        }
        //int runningTotal = 0;
        //bool keepGoing = true;

        //while (keepGoing)
        //{
        //    Console.Write("Enter the number of minutes you exercise or type 'quit' to exit: ");
        //    string userInput = Console.ReadLine();
        //    if (userInput == "quit")
        //    {
        //        keepGoing = false;
        //    }
        //    else
        //    {
        //        int minutes = int.Parse(userInput);
        //        runningTotal = runningTotal + minutes;

        //        Console.WriteLine($"Whaaaaaat!? that makes { runningTotal} total minutes. Awesome!");
        //        Console.WriteLine("");

        //    }


        //}
        //Console.WriteLine("K, bye");

        //Console.Read();

    }
}

