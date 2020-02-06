using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generates the array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            //Lists each element in the array to the user with a foreach loop
            foreach (int i in numbers) 
            {
                Console.WriteLine("Element value" + " = " + i + " ");        
            }
        }
    }
}
