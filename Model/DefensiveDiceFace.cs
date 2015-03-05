using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DefensiveDiceFace
    {
        public int Face { get; set; }
        public float Probability { get; set; }
        public int Armor { get; set; }
        public int Evade { get; set; }
        public int Dodge { get; set; }

        public DefensiveDiceFace() { }

        /// <summary>
        /// Constructor for defensive dice
        /// </summary>
        /// <param name="face"></param>
        /// <param name="armor"></param>
        /// <param name="evade"></param>
        /// <param name="dodge">0 for no dodge, 1 for dodge</param>
        public DefensiveDiceFace(int face, int armor, int evade, int dodge)
        {
            this.Face = face;
            this.Armor = armor;
            this.Evade = evade;
            this.Dodge = dodge;
            this.Probability = 1 / 6;
        }
    }
}
