using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLR2
{
    class Computer : Player
    {
        // Member Variables (HAS A)
        int randomNumber;
        // Constructor
        public Computer(string name)
        {
            this.name = name;
        }
        // Member Methods (CAN DO)
        public override string MakeMove()
        {
            Random randomNumberGenerator = new Random();
            randomNumber = randomNumberGenerator.Next(1, 5);
            switch (randomNumber)
            {
                case 1:
                    return "rock";
                case 2:
                    return "paper";
                case 3:
                    return "scissors";
                case 4:
                    return "lizard";
                case 5:
                    return "spock";
                default:
                    return "null";
            }
        }
    }
}
