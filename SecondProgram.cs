using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo
{
    internal class SecondProgram
    {

        static void SwapNos(int i, int j)
        {
            int k = i;//k=1
            i = j;//i=2
            j = k;//j=1
            Console.WriteLine($"Value of i={i}");
            Console.WriteLine($"Value of j={j}");
        }


        static void SwapNosRef(ref int i,ref int j)
        {
            int k = i;//k=1
            i = j;//i=2
            j = k;//j=1
            Console.WriteLine("Call by reference");
            Console.WriteLine($"Value of i={i}");
            Console.WriteLine($"Value of j={j}");
        }

        static void Main(string[] args)
        {
            int a= 1, b= 2;
            SwapNos(a, b);//Value of a and b ---Call by value
            Console.WriteLine($"Value of a={a}");
            Console.WriteLine($"Value of b={b}");
            Console.WriteLine("=============================");
            SwapNosRef(ref a, ref b);//Addresses of a and b-----Call by reference
            Console.WriteLine($"Value of a={a}");
            Console.WriteLine($"Value of b={b}");
        }
    }
}
