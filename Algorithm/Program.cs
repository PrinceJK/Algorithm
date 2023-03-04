
using System;
using LeetCode;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Array arr = new Array(2);
            arr.Insert(1);
            arr.Insert(2);
            arr.Insert(3);
            arr.Insert(4);
            arr.Insert(1000000000);
            arr.Insert(5);
            arr.Insert(6);
            arr.Insert(7);
            arr.Insert(8);
            arr.Insert(9);
            arr.Insert(10);
            Console.WriteLine(arr.Max());
            
            

            Console.ReadLine();
        }
    }
}
