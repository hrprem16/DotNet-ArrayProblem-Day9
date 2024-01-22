using System;
namespace findDuplicate
{

    class Program
    {


        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
