
using System;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Monodimensional array
            Random rnd = new Random(DateTime.Now.Second);
            int[] array = new int[]
            {
            rnd.Next(1024),
            rnd.Next(1024),
            rnd.Next(1024)
            };
            int[] array2 = new int[2];
            Console.WriteLine(array[1]);

            // Bidimensional Array
            string[,] items = new string[,]
            {
                {"Frutta", "Pesca" },
                {"Verdure", "Zucchina" }
            };
            Console.WriteLine($"Second array, item {items[0,1]}");
        }
    }
}