/*
 * Author: Isaac Cruz
 * Course: COMP003A
 * Purpose: looping statements
 */
namespace COMP003A.Assignment4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop selection");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));

            Console.WriteLine("Enter a positive whole number: ");
            string playerResponse = Console.ReadLine();
            
            int limit = Convert.ToInt32(Console.ReadLine());

            string output = "#";

            for (int i = 0; i <= limit; i ++)
            {
                output += "#";
            }

           


        }
    }
}
