using System;

class Program
{
    static void ReverseWord(char[] word, int start, int end)
    {
        while (start < end)
        {
            char temp = word[start];
            word[start] = word[end];
            word[end] = temp;
            start++;
            end--;
        }
    }

    static string ReverseWords(string input)
    {
        char[] charArray = input.ToCharArray();

        int start = 0;
        for (int end = 0; end < charArray.Length; end++)
        {
            if (charArray[end] == ' ' || end == charArray.Length - 1)
            {
                int wordEnd;
                if (end == charArray.Length - 1)
                {
                    wordEnd = end;
                }
                else
                {
                    wordEnd = end - 1;
                }

                ReverseWord(charArray, start, wordEnd);
                start = end + 1;
            }
        }

        return new string(charArray);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Call the function to reverse each word
        string reversedString = ReverseWords(input);

        Console.WriteLine($"Reversed string: {reversedString}");
    }
}
