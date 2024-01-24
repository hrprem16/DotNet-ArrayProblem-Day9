using System;

namespace CountElementFrequency
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                // Skip if the element is already processed
                if (arr[i] == -1)
                {
                    continue;
                }

                int count = 1;

                // Count the frequency of arr[i]
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        // Mark the repeated element as processed to avoid recounting
                        arr[j] = -1;
                    }
                }

                Console.WriteLine($"{arr[i]}: {count}");
            }
        }
    }
}
