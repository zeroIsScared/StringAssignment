using System;
using System.Collections.Generic;

namespace StringAsignment
{
    class Program
    {

        
        //- Display the word count of this string
        //- Display the sentence count of this string
        //- Display how often the word "encapsulation" appears in this string
        //- Display this string in reverse, without using any C# language feature. (Create your own algorith)
        //- In the given string, replace all occurances of "object-oriented programming" with "OOP" and display the new string
        static void Main(string[] args)
        {
            string text = @"In object-oriented programming, encapsulation is a fundamental principle that involves bundling data and methods that operate on that data within a single unit or class. This concept allows for the hiding of implementation details from the outside world and exposing only the necessary interfaces for interacting with the object. By encapsulating data and methods together, we promote code reusability, maintainability, and flexibility.One of the key benefits of encapsulation is the ability to enforce access control on the members of a class. This means we can specify which parts of the class are accessible to the outside world and which are not. By using access modifiers such as public, private, and protected, we can control the visibility of members, ensuring that they are only accessed in appropriate ways. For example, we may have a class representing a bank account with properties such as balance and methods for depositing and withdrawing funds. By making the balance property private and providing public methods for depositing and withdrawing funds, we encapsulate the internal state of the account and ensure that it can only be modified in a controlled manner. Encapsulation also allows us to enforce data validation and maintain invariants within our classes. By providing controlled access to data through methods, we can ensure that it is always in a valid state. For instance, when setting the balance of a bank account, we can check that the new balance is not negative before updating the internal state of the object. Overall, encapsulation is a powerful concept in object-oriented programming that promotes modularity, reusability, and maintainability. By bundling data and methods together within a class and controlling access to them, we can create more robust and flexible software systems.";
            string[] words = text.Split(' ');
            string[] sentences = text.Split('.');
          
            string newString = text.Replace("object-oriented programming", "OOP");
            string reverseString = "";
            

            List<string> encapsulations = new List<string>();

            foreach (string word in words)
            {
                Console.WriteLine(word);
                if (word.Contains("encapsulation"))
                {
                    encapsulations.Add(word);
                }
            }

            for (int i = words.Length; i >= 0; i-- )
            {
                if (words[i].Contains("."))
                {
                    words[i] = words[i].Replace(".", "");
                }
                reverseString = reverseString +" "+ words[i];
            }


            Console.WriteLine($"word count = {words.Length}");
            Console.WriteLine($"sentence count = {sentences.Length}");
            Console.WriteLine($"encapsulation count = {encapsulations.Count}");
            Console.WriteLine(newString);
            Console.WriteLine(reverseString);

            //Write a C# Sharp program to extract the Date property and display the DateTime value in the formatted output. 

var date = DateTime.Now;
var offSetTime = DateTimeOffset.Now;

var timeZone1 = TimeZone.CurrentTimeZone;
var timeZone2 = TimeZoneInfo.Utc;

string displayDateTime = String.Format("Today is {0} and the time is {1}", date.ToString("dd MMM, yyyy"), date.ToString("HH:mm"));
string displayDateTimeOffset = $"Off set Time : {offSetTime.ToString("MMM dd yy")}";
Console.WriteLine(displayDateTime);
Console.WriteLine(displayDateTimeOffset);
Console.WriteLine(timeZone1.DaylightName);
Console.WriteLine(timeZone2.DaylightName);

//Write a C# Sharp program to display the number of days of the year between two specified years. 

var bookingDate = new DateTime(2026, 05,25);
var bookingDate1 = new DateTime(2024, 04, 01);
var daysUntilTravel1 = (bookingDate1 - date).Days;
var daysUntilTravel = (bookingDate - date).Days;
TimeSpan interval = bookingDate - bookingDate1;

Console.WriteLine($" days:{interval.Days}, hours: {interval.Hours}, minutes: {interval.Minutes}");
Console.WriteLine( daysUntilTravel);
Console.WriteLine(daysUntilTravel1);


//10. Write a C# Sharp program to determine the day of the week 40 days after the current date. 

var dayOfTheWeek = date.AddDays(40).DayOfWeek;
Console.WriteLine(dayOfTheWeek);

//16.Write a C# Sharp program that compares two dates.

if (bookingDate > bookingDate1)
{ 
    Console.WriteLine($"The {bookingDate} is not earlier than {bookingDate1}");
}
else
{   

    Console.WriteLine($"The {bookingDate} is earlier than {bookingDate1}");
}

Console.WriteLine(bookingDate > bookingDate1);

//CultureInfo
Console.WriteLine(CultureInfo.CurrentCulture.Name);

int price = 20;
string culInfo = string.Format(new System.Globalization.CultureInfo("en-GB"), "{0:C}", price);

Console.WriteLine(culInfo);
        }
    }
}
