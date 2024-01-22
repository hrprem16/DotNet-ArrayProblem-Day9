using System;
namespace findDuplicate
{

    class Program
    {


        static void Main()
        {
            
            int[] arr = { 1, 2, 2, 3, 4, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                int j;

                for (j = 0; j < i; j++)
                {

                    if (arr[i] == arr[j])
                    {
                        break;

                    }

                }
                if (i == j) Console.Write(arr[i] + " ");


            }




        }
    }
}





































