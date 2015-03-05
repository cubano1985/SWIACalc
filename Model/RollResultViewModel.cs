using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RollResultViewModel
    {
        public float Probability { get; set; }
        public int Range { get; set; }
        public int Damage { get; set; }
        public int Surge { get; set; }

        public int BlueDice { get; set; }
        public int RedDice { get; set; }
        public int YellowDice { get; set; }
        public int GreenDice { get; set; }
    }
}
