using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLR2
{
    abstract class Player : ScoreBoard
    {
        // Member Variables (HAS A)
        public string name;
        public string move;

        // Member Methods (CAN DO)
        public virtual string MakeMove()
        {
            return "null";
        }
    }
}
