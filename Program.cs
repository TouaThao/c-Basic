using System;
using System.IO;

namespace c_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /// store a variable that take our location
            string workingFolder = @"/Users/touathao/Desktop/Pratice/C#/c#Project/";
            //use StreamReader sr and create a new StreamReader that take in our variable
            //WorkingFolder
            StreamReader sr = new StreamReader(workingFolder + "fileName.txt");
            //Now we create a string call line and we set it to empty
            StreamWriter sw = new StreamWriter(workingFolder + "fileNameReader.txt");
            string line = string.Empty;
            //While loop.
            while ((line = sr.ReadLine()) != null)
            {
                sw.WriteLine(line);
                
            }
            sr.Close();
            sw.Close();
                Console.WriteLine("Hello World");
        }
    }
}
