using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Choose an option
            //1 - Import Words from File
            //2 - Bubble Sort words
            //3 - LINQ/Lambda sort words
            //4 - Count the Distinct Words
            //5 - Take the last 10 words
            //6 - Reverse print the words
            //7 - Get and display words that end with 'd' and display the count
            //8 - Get and display words that contain 'q' and display the count
            //9 - Get and display words that are more than 3 characters long and start with the letter 'a', and display the count
            //x - Exit
            while (true)
            {
                //test
                Console.WriteLine(
                    "1 - Import Words from File\n" +
                    "2 - Bubble Sort words\n" +
                    "3 - LINQ/Lambda sort words\n" +
                    "4 - Count the Distinct Words\n" +
                    "5 - Take the last 10 words\n" +
                    "6 - Reverse print the words\n" +
                    "7 - Get and display words that end with 'd' and display the count\n" +
                    "8 - Get and display words that contain 'q' and display the count\n" +
                    "9 - Get and display words that are more than 3 characters long and start with the letter 'a', and display the count\n" +
                    "x - Exit");

                string i = Console.ReadLine();

                switch (i)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    case "x":
                        Console.WriteLine("Goodbye");
                        Thread.Sleep(100);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid selection, try again");
                        break;
                }

            }

        }


    }


}


