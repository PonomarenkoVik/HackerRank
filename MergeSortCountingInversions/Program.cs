using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortCountingInversions
{
    //MergeSortCountingInversions(isn't done)
    class Program
    {
        static void Main(string[] args)
        {
            var res = CountInversions(new int[] { 2, 1, 3, 1, 2 });
        }

        // Complete the countInversions function below.
        static long CountInversions(int[] arr)
        {
            int n = arr.Length;
          
            var sortedArray = (int[])arr.Clone();
            Array.Sort(sortedArray);
            var indicesArray = new int[n];

            int?[] cl = new int?[n];
            for (int i = 0; i < n; i++)
            {
                cl[i] = arr[i];
            }
            for (int i = 0; i < n; i++)
            {
                indicesArray[i] = Array.IndexOf(cl, sortedArray[i]);
                cl[indicesArray[i]] = null;
            }

            int swaps = 0;
            for (int i = 0; i < n; i++)
            {
                int val = indicesArray[i];
                if (val < 0) continue;
                while (val != i && arr[i] != sortedArray[i])
                {
                    int new_val = indicesArray[val];
                    indicesArray[val] = -1;
                    val = new_val;
                    swaps++;
                }
                indicesArray[i] = -1;
            }
            return swaps;

        }
    }
}
