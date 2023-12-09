using System;

class Program
{
    static void Main()
    {
        // Example usage
        string mainString = "stackoverflow";
        string prefix = "stack";
        
        int prefixLength = GetPrefixLength(mainString, prefix);

        Console.WriteLine($"The length of the prefix '{prefix}' in '{mainString}' is: {prefixLength}");
    }

    // Function to get the length of a prefix substring
    static int GetPrefixLength(string mainString, string prefix)
    {
        int length = 0;

        // Iterate through the characters of both strings until a mismatch is found
        while (length < mainString.Length && length < prefix.Length && mainString[length] == prefix[length])
        {
            length++;
        }

        return length;
    }
}
