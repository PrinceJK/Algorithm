using System;

namespace HackerRank
{
    public class Solution
    {
        public static string CatAndMouse(int x, int y, int z)
        {
            if (x == 0 || y == 0 || z == 0)
            {
                return "0";
            }
            var dist1 = Math.Abs(x - z);
            var dist2 = Math.Abs(y - z);
            
            if (dist1 > dist2)
            {
                return "Cat B";

            }
            else if (dist2 > dist1)
            {
                return "Cat A";
            }
            else
            {
                return "Mouse C";
            }
        }
    }
}
