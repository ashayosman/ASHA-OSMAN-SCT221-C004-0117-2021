using System;

class Program
{
    static void Main()
    {
        // Example usage
        string originalString = "Hello, World!";
        PrintStringInReverse(originalString);
    }

    // Function to print a string in reverse
    static void PrintStringInReverse(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        
        Console.WriteLine(reversedString);
    }
}
