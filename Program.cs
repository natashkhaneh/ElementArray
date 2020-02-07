using System;

namespace ElementArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Manually populated numbers array
            int [] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            // Writes a line to the console displaying the element value for each number in the numbers array
            foreach (int i in numbers)
            {
                Console.WriteLine("Element Value = " + i);
            }

        }
    }
}
