using System;

class Program
{
    static void Main()
    {
        // Generate a random number
        Random random = new Random();
        int n = random.Next(-1000, 1001);  // You can adjust the range as needed

        // Extract the last digit of the number
        int lastDigit = Math.Abs(n % 10);

        // Print the last digit
        Console.WriteLine($"The last digit of the number {n} is {lastDigit}.");
    }
}
