using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");

        // Call the swap function
        Swap(ref a, ref b);

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }

    // Function to swap two integers
    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
