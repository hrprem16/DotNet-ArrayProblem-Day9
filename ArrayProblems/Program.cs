using System;

class Program
{
   
    
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 },{4,7,8 } };
            
            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                int sum = 0;
                for(int j = 0; j < numbers.GetLength(1); j++)
                {
                 sum += numbers[i, j];
                }
            Console.WriteLine($"Sum of {i} th row is {sum}");

            }
        }
    
}
