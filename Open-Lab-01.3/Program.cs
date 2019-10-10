using System;
using System.IO;

namespace Open_Lab_01._1
{
    class GFG
    {
        public static void Main()
        {
            Console.WriteLine("Enter your number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            int result = AddOne(number);

            Console.WriteLine($"This is the result: {result}");
        }

        private static int AddOne(int number)
        {
            number = number + 1;
            return number;
        }
    }
}
