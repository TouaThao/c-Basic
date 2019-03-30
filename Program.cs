using System;
using System.IO;
using System.Collections.Generic;

namespace c_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> myCustomerList = new List<Customer>();
         myCustomerList = GetCustomerFromFile();
         Console.WriteLine("Hello World");
        }
        static public List<Customer> GetCustomerFromFile()
        {
            //Now we need to use the System.collections.generic; and create a list
            //Now we have a list. We need to use the public Customer we created.
            List<Customer> myCustomerList = new List<Customer>();
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
            // now we got access to the customer
            // Customer myCustomer = new Customer
            // we need to added it to an array
            // so we need to remove sw.WriteLine(line) to string [] 
            // Also we need to Split it cause we got comma
            //Remeber declare it first before we could use the Customer info
            //Now we need to add myCusomter to myCustomerList
            //If we don't add to myCustomerList it will just over write myCustomer.
            {
                string[] CustomerLine = line.Split(",");
                Customer myCustomer = new Customer();
                myCustomer.ID = CustomerLine[0];
                myCustomer.Name = CustomerLine[1];
                myCustomer.Gender = CustomerLine[2];
                myCustomerList.Add(myCustomer);
            }
            //After we're done we need to create a function that take in what we made
            //And pass it back up to the original static void Main(string[] args)
            //This will keep the code cleaner.
            //Also we need to return myCustomerList.
            sr.Close();
            sw.Close();
            
            return myCustomerList;
        }
       
    }
}

//If we add public it mean anyone anywhere could see it
//So we're going to added it to the string
public class Customer
{
    public string ID;
    public string Name;
    public string Gender;

}