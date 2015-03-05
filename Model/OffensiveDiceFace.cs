using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OffensiveDiceFace
    {
        public int Face { get; set; }
        public float Probability { get; set; }
        public int Range { get; set; }
        public int Damage { get; set; }
        public int Surge { get; set; }

        public OffensiveDiceFace() { }

        /// <summary>
        /// Offensive for offensive dice
        /// </summary>
        /// <param name="face"></param>
        /// <param name="range"></param>
        /// <param name="damage"></param>
        /// <param name="surge"></param>
        public OffensiveDiceFace(int face, int range, int damage, int surge)
        {
            this.Face = face;
            this.Range = range;
            this.Damage = damage;
            this.Surge = surge;
            this.Probability = 1 / 6;
        }
    }
}
