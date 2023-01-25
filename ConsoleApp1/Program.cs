/*
 * Console Program Lab 1
 * CST8359 302
 * By: Kelsey Phillips 
 */
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
            //Program object
            Program x = new Program();

            while (true)
            {
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
                //Get input from user
                string i = Console.ReadLine();
               
                //Selection
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
                        x.ReversePrint(x.words);
                        break;
                     //Display words that end with D and display count
                    case "7":
                        if (x.words.Count == 0)
                        {
                            Console.WriteLine("Please load words first!");
                            break;
                        }
                        x.EndWithD(x.words);
                        break;
                    //Contain q and print them and count
                    case "8":
                        if (x.words.Count == 0)
                        {
                            Console.WriteLine("Please load words first!");
                            break;
                        }
                        x.ContainsQ(x.words);
                        break;
                    //More than 3 letters long and start with a
                    case "9":
                        if (x.words.Count == 0)
                        {
                            Console.WriteLine("Please load words first!");
                            break;
                        }
                        x.MoreThan3Long(x.words);
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

        //|..//..//..//..//words.txt

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

        //Sort by bubblesort
        private IList<string> BubbleSort(IList<string> words)
        {
            var temp = words.ToList();
            var watch = new System.Diagnostics.Stopwatch();
            string temp2 ="";
            watch.Start();
            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = 0; j < temp.Count-1; j++)
                {
                    if (temp[j].CompareTo(temp[j+1]) > 0)
                    {
                        temp2 = temp[j + 1];
                        temp[j + 1] = temp[j];
                        temp[j] = temp2;
                    }
                }
            }
            watch.Stop();
            var time = watch.ElapsedMilliseconds;

            Console.WriteLine("Time elapsed: " + time + "ms");
            return temp;
        }

        //Sort using Linq
        private IList<string> LINQSort(IList<string> words)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var temp = words.OrderBy(x => x).ToList();
            watch.Stop();
            var time = watch.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: " + time + "ms");
            return temp;
        }
        //Find distinct words with Linq
        private IList<string> LINQDistinct (IList<string> words)
        {
            int count = words.Distinct().ToList().Count();
            Console.WriteLine("Distinct count is " + count);
            return words;
        }
        //Get 10 last words
        private IList<string> LINQLast10(IList<string> words)
        {
            words = words.Reverse().Take(10).Reverse().ToList();
            foreach(string word in words)
                Console.WriteLine(word); 
            return words;
        }
        //Reverse print list
        private void ReversePrint(IList<string> words)
        {
            words = words.Reverse().ToList();
            foreach (String word in words)
                Console.WriteLine(word);
        }
        //Words that end in D
        private void EndWithD(IList<string> words)
        {
            words = words.Where(x => x.EndsWith('d')).ToList();
            int count = words.Count();
            Console.WriteLine("The " + count + " words that end in 'd' are;");
            foreach (String word in words)
                Console.WriteLine(word);        
        }
        //Words that have Q
        private void ContainsQ(IList<string> words)
        {
            words = words.Where(x => x.Contains('q')).ToList();
            int count = words.Count();
            Console.WriteLine("The " + count + " words that contain 'q' are; ");
            foreach (String word in words)
                Console.WriteLine(word);
        }
        //Words that are longer than 3 characters and have an 'a'
        private void MoreThan3Long(IList<string> words)
        {
            words = words.Where(x => x.Length > 3 && x.StartsWith('a')).ToList();
            int count = words.Count();
            Console.WriteLine("The " + count + " words that are more 3 characters and start with 'a' are;");
            foreach(String word in words)
                Console.WriteLine(word);
        }

    }


}


