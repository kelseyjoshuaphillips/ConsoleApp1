using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        private StreamReader input;
        private IList<string> words = new List<string>();
        static void Main(string[] args)
        {
            Program x = new Program();
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
                    //Imports Words from File
                    case "1":
                        x.Import();
                        break;
                    //Bubblesort
                    case "2":
                        if (x.words.Count == 0)
                        {
                            Console.WriteLine("Please load words first!");
                            break;
                        }
                        x.BubbleSort(x.words);

                        break;
                    //Linq Sort
                    case "3":
                        if (x.words.Count == 0)
                        {
                            Console.WriteLine("Please load words first!");
                            break;
                        }
                        x.LINQSort(x.words);
                        break;
                    //Count distinct words
                    case "4":
                        if (x.words.Count == 0)
                        {
                            Console.WriteLine("Please load words first!");
                            break;
                        }
                        x.LINQDistinct(x.words);
                        break;
                    //Last 10 words of file
                    case "5":
                        if (x.words.Count == 0)
                        {
                            Console.WriteLine("Please load words first!");
                            break;
                        }
                        x.LINQLast10(x.words);
                        break;
                    //Print in reverse order
                    case "6":
                        if (x.words.Count == 0)
                        {
                            Console.WriteLine("Please load words first!");
                            break;
                        }
                        break;
                     //Display words that end with D and display count
                    case "7":
                        if (x.words.Count == 0)
                        {
                            Console.WriteLine("Please load words first!");
                            break;
                        }
                        break;
                    //Contain q and print them and count
                    case "8":
                        if (x.words.Count == 0)
                        {
                            Console.WriteLine("Please load words first!");
                            break;
                        }
                        break;
                    //More than 3 letters long and start with a
                    case "9":
                        if (x.words.Count == 0)
                        {
                            Console.WriteLine("Please load words first!");
                            break;
                        }
                        break;
                    //Exit
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
        private void Import()
        {
            input = new StreamReader("Words.txt");
            string line;
             
            while ((line = input.ReadLine())!= null)
            {
                words.Add(line);
            }
            Console.WriteLine("There are " + words.Count() + " words.");
        }

        private IList<string> BubbleSort(IList<string> words)
        {
            var watch = new System.Diagnostics.Stopwatch();
            string temp ="";
            watch.Start();
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < words.Count-1; j++)
                {
                    //if (string.Compare(words[j], words[j+1]) > 0)
                    //if (words[j].Length > words[j + 1].Length)
                    if (words[j].CompareTo(words[j+1]) > 0)
                    {
                        temp = words[j + 1];
                        words[j + 1] = words[j];
                        words[j] = temp;
                    }
                }
            }
            watch.Stop();
            var time = watch.ElapsedMilliseconds;

            Console.WriteLine("Time elapsed: " + time + "ms");
            return words;
        }

        private IList<string> LINQSort(IList<string> words)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            words = words.OrderBy(x => x).ToList();
            watch.Stop();
            var time = watch.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: " + time + "ms");
            return words;
        }
        private IList<string> LINQDistinct (IList<string> words)
        {
            //words = words.Distinct().OrderBy(x => x).ToList();
            //var blah = words.Take(10);
            //foreach(string word in blah)
            //Console.WriteLine(word);
            int count = words.Distinct().ToList().Count();
            Console.WriteLine("Distinct count is " + count);
            return words;
        }
        private IList<string> LINQLast10(IList<string> words)
        {
            words = words.Reverse().Take(10).Reverse().ToList();
            foreach(string word in words)
                Console.WriteLine(word); 
            return words;
        }
    }


}


