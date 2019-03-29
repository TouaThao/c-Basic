using System;
using System.IO;

namespace c_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /// store a variable that take our location
            string workingFolder = @"/Users/touathao/Desktop/Pratice/C#/c#Project/fileName.txt";
            //use StreamReader sr and create a new StreamReader that take in our variable
            StreamReader sr = new StreamReader(workingFolder);
            //Now read our StreamReader sr
            string line = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                string s = line;
            }

                Console.WriteLine("Hello World");
        }
    }
}
