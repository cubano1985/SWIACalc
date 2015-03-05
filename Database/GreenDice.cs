using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Database
{
    public static class GreenDice
    {
        static public List<OffensiveDiceFace> GreenResults;

        static GreenDice()
        {
            GreenResults = new List<OffensiveDiceFace>();
            GreenResults.Add(new OffensiveDiceFace(1, 1, 0, 1));
            GreenResults.Add(new OffensiveDiceFace(2, 1, 1, 1));
            GreenResults.Add(new OffensiveDiceFace(3, 1, 2, 0));
            GreenResults.Add(new OffensiveDiceFace(4, 3, 2, 0));
            GreenResults.Add(new OffensiveDiceFace(5, 2, 1, 1));
            GreenResults.Add(new OffensiveDiceFace(6, 2, 2, 0));
        }
    }
}
