using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;


namespace FileIO
{
    class Program
    {
        public static void readTextFile(string path)
        {
            ArrayList words = new ArrayList();
            try
            {
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine($"{lines.Length} lines read.");
                int blankLines = 0;
                foreach(var line in lines)
                {
                    if (line.Length < 1) blankLines++;
                    foreach (var word in line.Split(' '))
                    {
                        if(word.Trim(' ').Length > 0)
                        words.Add(word);
                    } 
                }
                Console.WriteLine($"{blankLines} empty lines ({lines.Length - blankLines}) ");
                Console.WriteLine($"{words.Count} words in the file");

                List<string> distinctWords = new List<string>();
                foreach (string word in words)
                {
                    if (!distinctWords.Contains(word))
                    {
                        distinctWords.Add(word);
                    }
                }
                Console.WriteLine($"{distinctWords.Count} distinct words in the file");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("can't open file for reading", path);

            }
        }
        static void Main(string[] args)
        {
            string location = "C:\\Users\\Ariel Anicete\\Desktop\\new1lyrics.txt";
            readTextFile(location);
        }
    }
}
