using System;

class Program
{
   
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (number != 0)
        {
            int q = number % 10;
            sum += q;
            number = number / 10;
        }
        Console.WriteLine($"The sum of the digit is {sum}");
    }
}
