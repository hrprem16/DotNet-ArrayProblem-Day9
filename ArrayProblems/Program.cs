using System;
namespace findDuplicate
{

    class Program
    {


        static void Main()
        {

            int[] arr = { 10, 7, 12, 14,17, 2,  15};
            int min = arr[0]; //Assume the 0th index value is minimum
            int max = arr[5]; //Assume the last index value is maximum
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
              
            }
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > max)
                {
                    max = arr[j];
                }

            }
            Console.WriteLine($"The Minimum element in the given array is {min}");
            Console.WriteLine($"The Minimum element in the given array is {max}");

        }
    }
}
