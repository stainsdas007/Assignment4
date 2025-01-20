//find the length of a string without using library function.
namespace Assignment4_1A
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            // Getting user input as the string
            Console.Write("Enter a string: ");
            string word = Console.ReadLine();

            // Find the length manually
            int length = 0;

            // Loop for iterating each of the character 
            foreach (char c in word)
            {
                length++;
            }

            // Display the length of the string
            Console.WriteLine($"The length of the string is: {length}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}