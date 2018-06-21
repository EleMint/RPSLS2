using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLR2
{
    class Human : Player
    {
        // Member Variables (HAS A)
        public string secondTry;
        // Constructor
        public Human(string name)
        {
            this.name = name;
        }
        // Member Methods (CAN DO)
        public override string MakeMove()
        {
            Console.WriteLine("\r\n" + "Please Pick A Weapon. (Rock, Paper, Scissors, Lizard, Spock");
            move = Console.ReadLine().ToLower();
            if (move == "rock" || move == "paper" || move == "scissors" || move == "lizard" || move == "spock")
            {
                return move;
            }
            else
            {
                Console.WriteLine("\r\n" + "Please Try Again.");
                secondTry = Console.ReadLine().ToLower();
                if (secondTry == "rock" || secondTry == "paper" || secondTry == "scissors" || secondTry == "lizard" || secondTry == "spock")
                {
                    return secondTry;
                }
                else
                {
                    Console.WriteLine("\r\n" + "Your Move Has Been Made For You");
                    Random myRandomNumber = new Random();
                    int myNumber = myRandomNumber.Next(1, 5);
                    switch (myNumber)
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
    }
}
