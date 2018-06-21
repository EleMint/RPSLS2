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
        public override string MakeMove(int numberofComputers)
        {
            Random randomNumberGenerator = new Random();
            randomNumber = randomNumberGenerator.Next(1, 5);
            return listOfGestures[randomNumber];
        }
    }
}
