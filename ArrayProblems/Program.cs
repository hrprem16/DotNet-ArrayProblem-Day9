using System;

namespace CountElementFrequency
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

            for(int i=0;i<arr.Length;i++){
                if(arr[i]==-1){
                    continue;
                    
                }
                int count =1;
                for(int j=i+1;j<arr.Length;j++){
                    if(arr[i]==arr[j]){
                        count++;
                        arr[j]=-1;
                    }
                }
                Console.WriteLine($"Occurence of {arr[i]} is : {count}");
            }
        }
    }
}
