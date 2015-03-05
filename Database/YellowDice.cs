using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Database
{
    public static class YellowDice
    {
        static public List<OffensiveDiceFace> YellowResults;

        static YellowDice()
        {
            YellowResults = new List<OffensiveDiceFace>();

            YellowResults.Add(new OffensiveDiceFace(1, 0, 0, 1));
            YellowResults.Add(new OffensiveDiceFace(2, 2, 1, 0));
            YellowResults.Add(new OffensiveDiceFace(3, 1, 1, 1));
            YellowResults.Add(new OffensiveDiceFace(4, 1, 2, 0));
            YellowResults.Add(new OffensiveDiceFace(5, 0, 1, 2));
            YellowResults.Add(new OffensiveDiceFace(6, 2, 0, 1));
        }
    }
}
