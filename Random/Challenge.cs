using System;
using System.Collections.Generic;
using System.Linq;

namespace Random
{
    public static class Challenge
    {

        public static int LaptopRentals(int[][] times)
        {
            if (times[0].Length == 0)
            {
                return 0;
            }

            int[] startTimes = new int[times.Length];
            int[] endTimes = new int[times.Length];
            for (int i = 0; i < times.Length; i++)
            {
                startTimes[i] = times[i][0];
                endTimes[i] = times[i][1];
            }

            int usedLaptops = 0;
            Array.Sort(startTimes);
            Array.Sort(endTimes);
            int startIndex = 0;
            int endIndex = 0;



            while (startIndex < startTimes.Length)
            {
                if (endTimes[endIndex] > startTimes[startIndex])
                {
                    usedLaptops++;
                    startIndex++;
                }
                else if (endTimes[endIndex] <= startTimes[startIndex])
                {
                    endIndex++;
                    startIndex++;
                }
            }



            return usedLaptops;
        }
    }
}
