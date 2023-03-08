
using System;

namespace ConsoleAppStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFirstName = "Marco";
            string myLastName = "Crespi";
            DateTime myBirthday = new DateTime(1996, 6, 20);
            float myHeight = 1.86746F;
            byte myAge = Convert.ToByte(DateTime.Now.Year - myBirthday.Year);
            decimal bigNumber = 136261.43284732M;

            string text_1 = "Hello! My name is " + myFirstName + " and my last name is " + myLastName;
            string text_2 = String.Format("Hello! My name is {0} and my last name is {1}", myFirstName, myLastName);
            string text_3 = $"Hello! My name is {myFirstName} and my last name is {myLastName}";
            string text_4 = String.Format("My birthday is {0: dd MM yyyy} and I was born on {0: dd MM yyyy}", myBirthday);
            string text_5 = $"Hello! My name is {myFirstName: dd MM yyyy} and my last name is {myLastName: dd MM yyyy}";
            string text_6 = $"I am {myHeight:N2} m";

            Console.WriteLine($"Big number {bigNumber:###.000}"); //Big number  136261.433
            Console.WriteLine($"Big number {bigNumber:###.0}"); //Big number  136261.4
            Console.WriteLine($"Big number {bigNumber:E}"); // Big number 1.362614E+005
            Console.WriteLine($"Big number {bigNumber:c2}"); // Big number £136,261.43

            int index = text_3.IndexOf("My");
            Console.WriteLine("Word - My - is present at position " + index.ToString());
            Console.WriteLine($"Substring: {text_3.Substring(index, 4)}");
        }
    }
}