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
        public List<string> listOfGestures = new List<string>();

        public Player()
        {
            listOfGestures.Add("rock");
            listOfGestures.Add("paper");
            listOfGestures.Add("scissors");
            listOfGestures.Add("lizard");
            listOfGestures.Add("spock");
        }

        // Member Methods (CAN DO)
        public virtual string MakeMove(int numberOfComputers)
        {
            return "null";
        }
    }
}
