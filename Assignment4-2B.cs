//namespace Assignment4_2B
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Getting user input as  string 
//            Console.Write("Enter a string: ");
//            string word = Console.ReadLine();

//            Console.WriteLine("The characters of the string in reverse order is:");

//            // loop to print characters in reverse order
//            for (int i = word.Length - 1; i >= 0; i--)
//            {
//                Console.WriteLine(word[i]);
//            }

//            Console.WriteLine("Press any key to exit...");
//            Console.ReadLine();
//        }
//    }
//}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string word = Console.ReadLine();

        Console.Write("The characters of the string in reverse order are: ");

        // loop to concatenate characters in reverse order
        for (int i = word.Length - 1; i >= 0; i--)
        {
            Console.Write(word[i]); // Write without a newline
        }

        Console.WriteLine(); // Add a new line after the reverse string
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
