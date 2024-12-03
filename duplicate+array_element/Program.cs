using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate_array_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr=new int[5];
            Console.WriteLine("Enter the array element");
            for(int i = 0;i<5;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("print Duplcate array element");
            for(int i = 0; i<5;i++)
            {
                for(int j = i+1; j<5;j++)
                {
                    if(arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[j]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
