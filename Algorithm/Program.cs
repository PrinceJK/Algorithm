using System;
using HackerRank;
using Random;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(Kata.Kata5.ParseMolecule("H2O").ToString());

            //LaptopRentalsSol1.LaptopRentals(new int[][] { new int[] {} });
            int [] chk = new int[] { 1, 2, 3 };
            var sln = Challenge.ReturnOddNumbers(chk);
            foreach (var item in sln)
            {
                //System.Console.WriteLine(item);
            }


            var res = Solution.CatAndMouse(1, 3, 2);
            Console.WriteLine(res);

        }
    }
}
