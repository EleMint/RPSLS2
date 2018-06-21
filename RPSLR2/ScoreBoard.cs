using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLR2
{
    class ScoreBoard
    {
        // Member Variables (HAS A)

        public int player1Score;
        public int player2Score;

        // Constructor

        public ScoreBoard()
        {
            this.player1Score = 0;
            this.player2Score = 0;
        }

        // Member Methods (CAN DO)

        public void AddPointPlayer1()
        {
            player1Score += 1;
        }

        public void AddPointPlayer2()
        {
            player2Score += 1;
        }

        public void DisplayMoves(string player1Name, string player2Name, string player1Move, string player2Move)
        {
            Console.WriteLine("\r\n" + "--Moves--" + "\r\n" + player1Name + ": " + player1Move + "\r\n" + player2Name + ": " + player2Move);
        }

        public void DisplayScore(string player1Name, string player2Name)
        {
            Console.WriteLine("\r\n" + "--Scores--" + "\r\n" + player1Name + ": " + player1Score + "\r\n" + player2Name + ": " + player2Score);
        }
    }
}
