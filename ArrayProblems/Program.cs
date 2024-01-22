using System;
namespace findDuplicate
{

    class Program
    {


        static void Main()
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] == arr[j])
                    {
                        count++;


                    }
                }
            }
            Console.WriteLine($"Total number of duplicate element in the give arrays are : {count}");
        }
    }
}





































