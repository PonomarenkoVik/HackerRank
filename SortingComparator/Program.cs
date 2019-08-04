using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingComparator
{
    // не проходит тест почему то
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Player() { Name = "amy", Score = 100 };
            var p2 = new Player() { Name = "david", Score = 50};
            var res = Comparator(p1, p2);
        }

        static int Comparator(Player a, Player b)
        {
            if (a.Score != b.Score)
                return a.Score.CompareTo(b.Score);

            return a.Name.CompareTo(b.Name);         
        }


    }

    class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
