namespace Assignment4_4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //compare two string without using string library functions.


            // Get two strings from the user
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

                    //compare both string are same or not
                    if (str1 == str2)
                    {
                        Console.WriteLine(" Both strings are same");
                    }
                    else
                    {
                        Console.WriteLine("Both strings are not same");
                    }              

        }
    }
}