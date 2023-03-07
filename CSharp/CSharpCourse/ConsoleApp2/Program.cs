
using System;
using System.Linq.Expressions;

namespace ConsoleAppBatteryCharge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string RESULT_CHARGE_LABEL = "Battery charge at: ";
            int batteryLevel;
            bool inCharge;
            Random rnd;
            Random rndCharge;

            Console.WriteLine("Battery charge recovery...");

            rnd = new Random(DateTime.Now.Second);
            batteryLevel = rnd.Next(0,100);
            
            rndCharge = new Random(DateTime.Now.Second);
            inCharge = rndCharge.Next(0, 1) <= 5;
            Console.WriteLine($"Read value: {batteryLevel} ({ (inCharge ? "On charge" : "Not in charge" )})");

            if ((batteryLevel>=0) && (batteryLevel<25))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            } else if ((batteryLevel >= 25) && (batteryLevel < 50))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            } else if ((batteryLevel >= 50) && (batteryLevel < 75))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            } else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            Console.WriteLine($"{RESULT_CHARGE_LABEL} {batteryLevel}%");

            if (inCharge)
            {
                Console.WriteLine("Still charging...");
            }
            Console.ResetColor();

        }
    }
}