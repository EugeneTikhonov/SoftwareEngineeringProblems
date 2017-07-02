using System;

namespace Solutions
{
    /// <summary>
    /// Given an almost sorted array where only two elements are swapped, how to sort the array efficiently?
    /// </summary>
    public class SortAlmostSorted
    {
        public void Solve(int[] a)
        {
            var great = -1;
            var small = -1;
            for (var i = 0; i < a.Length - 1; i++)
            {
                if (a[i + 1] < a[i])
                {
                    if (great == -1)
                    {
                        great = i;
                    }
                    else
                    {
                        small = i + 1;
                    }
                }
            }

            if (great == -1 || small == -1)
            {
                throw new ArgumentException("Wrong input data");
            }

            var temp = a[great];
            a[great] = a[small];
            a[small] = temp;
        }
    }
}