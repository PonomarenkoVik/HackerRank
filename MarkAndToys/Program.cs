using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkAndToys
{
    //Interview Preparation KitSortingMark and Toys
    class Program
    {
        static void Main(string[] args)
        {
            var res = MaximumToys(new int[] { 1, 12, 5, 111, 200, 1000, 10 }, 50);
            Console.WriteLine(res);
            Console.ReadLine();
        }


        static int MaximumToys(int[] prices, int k)
        {

            Array.Sort(prices);
            int sum = 0;
            int count = 0;
            foreach (var p in prices)
            {
                if (sum + p < k)
                {
                    sum += p;
                    count++;
                    continue;
                }
                break;
            }
            return count;
        }

    }
}
