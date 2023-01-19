using System;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        private StreamReader input;
        IList<string> words = new List<string>();
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
                Program x = new Program();

                switch (i)
                {
                    //Imports Words from File
                    case "1":
                        x.import();
                        break;

                    case "2":
                        //if (words)
                        //{
                         //   Console.WriteLine("No words in array");
                       // }
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

        //Import words from a text file and return the number of words
        private void import()
        {
            input = new StreamReader("C:/Users/Kelsey Phillips/OneDrive - Algonquin College/Documents/Level5/CST8359 - dotNet Enterprise/Lab/repos/ConsoleApp1/Words.txt");
            string line;
            words 
 
            while ((line = input.ReadLine())!= null)
            {
                words.Add(line);
            }
            Console.WriteLine("There are " + words.Count() + " words.");
        }


    }


}


