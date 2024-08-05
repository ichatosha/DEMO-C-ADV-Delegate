using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_C__ADV_Delegate
{
    internal class CompareFunctions
    {

        public static bool CompareGreat(int x , int y)
        {
            return x > y;
        }

        public static bool CompareLess(int x, int y)
        {
            return x < y;
        }

        public static bool SortAsec(string x, string y)
        {
            return x?.Length > y?.Length;
        }

        public static bool SortDesc(string x, string y)
        {
            return x?.Length < y?.Length;
        }

    }
}
