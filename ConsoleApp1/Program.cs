using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str = new List<string>();
            string word = "";
            string longest = "";
            int count = 0;
            Console.WriteLine("Writing to words:");
            do
            {
                word = Console.ReadLine();
                if (word != "exit")
                {
                    str.Add(word);
                }
                count++;

            } while (word != "exit");
            /*Console.WriteLine("\nWords:");
            foreach (string s in str)
            {
                Console.WriteLine(s);
            }*/
            for (int i = 1; i < str.Count; i++)
            {
                if (str[i-1].Length < str[i].Length)
                {
                    longest = str[i];
                }
            }
            Console.WriteLine("\nThe longest word: {0} - {1} symbols", longest.ToUpper(), longest.Length);
            Console.ReadLine();
        }
    }
}