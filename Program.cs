//A name space
using System;
// Use
using System.IO;
//
using System.Collections.Generic;
//
using System.Linq;

//**************/
//Your task with creating a file that take in all the employee and 
// filter them by ID,Name,and Gender
//**************/

//Create the class/Constructor so we could use it
//If we add public it mean anyone anywhere could see it
//So we're going to added it to the string
public class Customer
{
    public string ID;
    public string Name;
    public string Gender;

}

namespace c_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new List that have property of Customer and we call it FullCustomerList
            // we set FullCustomerList to the function GetCustomerFromFile()
            List<Customer> FullCustomerList = new List<Customer>();
            FullCustomerList = GetCustomerFromFile();

            //Create a new list that have property of Customer and we call it women
            //Now we set Women to FullCustomerList and filter it with .Where
            //And with .where we set a variable x
            //And that variable X return(=>) any x person with a gender == "Female"
            List<Customer> Women = new List<Customer>();
            Women = FullCustomerList.Where(x => x.Gender == "Female").ToList();

            //Now create a streamWriter to create the collected data into a new file
            //Create one for female
            StreamWriter sw1 = new StreamWriter(@"/Users/touathao/Desktop/Pratice/C#/c#Project/women.txt");

            //Now loop through it
            //Take property of Customer i.e id,name,gender
            // And name it myLady.
            // and use the file in Women where we filter already.
            foreach(Customer mylady in Women){
                sw1.WriteLine(mylady.ID + " " + mylady.Name + " " + mylady.Gender);
            }
            //Close the StreamWriter
            sw1.Close();
            //Create a new list that have property of Customer and we call it Men
            //Now we set Men to FullCustomerList and filter it with .Where
            //And with .where we set a variable x
            //And that variable X return(=>) any x person with a gender == "Male"
            List<Customer> Men = new List<Customer>();
            Men = FullCustomerList.Where(x => x.Gender == "Male").ToList();

            //Create a new StreamWritter for men
            StreamWriter sw2 = new StreamWriter(@"/Users/touathao/Desktop/Pratice/C#/c#Project/men.txt");

            //Loop through it
            //Take property of Customer 
            //Name it myDude
            //And take it from Men where we filter it
            //And use SW to writeLine
            foreach(Customer myDude in Men){
                sw2.WriteLine(myDude.ID + " " + myDude.Name+ " "+ myDude.Gender);
            }
            sw2.Close();
            
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
