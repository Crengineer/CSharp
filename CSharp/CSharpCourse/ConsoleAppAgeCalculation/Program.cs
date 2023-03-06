
using System;

namespace ConsoleAppAgeCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAJOUR_AGE = 18;
            string FirstName;
            string LastName;
            int age;
            DateTime birthDay;
            int offsetMajourDate;

            Console.WriteLine("Insert the informations:");
            Console.Write("Insert your name:");
            FirstName = Console.ReadLine();

            Console.Write("Insert your surname:");
            LastName = Console.ReadLine();

            Console.Write("Insert your birthday (dd/mm/yyyy):");
            birthDay = Convert.ToDateTime(Console.ReadLine());

            // I have to verify that the user is 18+ years old

            age = DateTime.Now.Year - birthDay.Year;

            if (age >= MAJOUR_AGE)
            {
                Console.WriteLine("You are an adult!");

            } else
            {
                offsetMajourDate = MAJOUR_AGE - age;
                Console.WriteLine($"Must wait {offsetMajourDate} to become legally adult"); // $ keyword is to integrate datatype into string
            }

        }
    }
}