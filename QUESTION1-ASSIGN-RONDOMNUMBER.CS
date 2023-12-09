using System;

class Program
{
    static void Main()
    {
        // Generate a random number
        Random random = new Random();
        int n = random.Next(-100, 101);  // You can adjust the range as needed

        // Check if the number is positive or negative and print the result
        if (n > 0)
        {
            Console.WriteLine($"The number {n} is positive.");
        }
        else if (n < 0)
        {
            Console.WriteLine($"The number {n} is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
