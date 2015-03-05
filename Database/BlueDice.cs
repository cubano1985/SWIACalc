using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Database
{
    public static class BlueDice
    {
        public static List<OffensiveDiceFace> BlueResults;

        static BlueDice()
        {
            BlueResults = new List<OffensiveDiceFace> 
            { 
                new OffensiveDiceFace(1, 2, 1, 0),
                new OffensiveDiceFace(2, 2, 0, 1),
                new OffensiveDiceFace(3, 3, 2, 0),
                new OffensiveDiceFace(4, 4, 2, 0),
                new OffensiveDiceFace(5, 3, 1, 1),
                new OffensiveDiceFace(6, 5, 1, 0)
            };
        }
    }
}
