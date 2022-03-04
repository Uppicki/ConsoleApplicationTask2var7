using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApplicationTask2var7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"P:\RiderProjects\ConsoleApplicationTask2var7\";
            string pathIn = path + @"ConsoleApplicationTask2var7\input.txt";
            Console.WriteLine("Write output file name");
            string pathOut = path + Console.ReadLine() + "out.txt";

            //string[] input = readFromFile(pathIn);
            
            string[] lines = readFromFile(pathIn);
            
            writeToFile(pathOut, lines);
        }

        private static string[] readFromFile(string path)
        {
            return File.ReadAllLines(path);
        }
        
        private static void writeToFile(string path, string[] text)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false);
                foreach (string line in text)
                {
                    sw.Write(line + " ");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}