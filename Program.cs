using System;
namespace ArrayRotation{
    class Program{
        public static void Main(){
            int n=int.Parse(Console.ReadLine());
            int r=int.Parse(Console.ReadLine());
            string[] arr=Console.ReadLine().Split(",");
            int[] num=new int[arr.Length];
            for(int i=0;i<n;i++)
            {
                num[i]=int.Parse(arr[i]);
            }
            if(r>num.Length)
            {
                r-=num.Length;
                for(int i=r;i<num.Length;i++)
                {
                    Console.Write(num[i]+" ");
                }
                for(int i=0;i<r;i++)
                {
                    Console.Write(num[i]+" ");
                }
            }
            else
            {
                for(int i=r;i<num.Length;i++)
                {
                    Console.Write(num[i]+" ");
                }
                for(int i=0;i<r;i++)
                {
                    Console.Write(num[i]+" ");
                }
            }
        }
    }
}
