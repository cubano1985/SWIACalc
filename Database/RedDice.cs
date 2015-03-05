using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Database
{
    public static class RedDice
    {
        static public List<OffensiveDiceFace> RedResults;

        static RedDice()
        {
            RedResults = new List<OffensiveDiceFace>();

            RedResults.Add(new OffensiveDiceFace(1, 0, 1, 0));
            RedResults.Add(new OffensiveDiceFace(2, 0, 2, 0));
            RedResults.Add(new OffensiveDiceFace(3, 0, 3, 0));
            RedResults.Add(new OffensiveDiceFace(4, 0, 3, 0));
            RedResults.Add(new OffensiveDiceFace(5, 0, 2, 0));
            RedResults.Add(new OffensiveDiceFace(6, 0, 2, 1));
        }
    }
}
