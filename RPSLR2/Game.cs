using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLR2
{
    class Game
    {
        // Member Variables (HAS A)

        public Player player1;
        public Player player2;
        ScoreBoard scoreBoard = new ScoreBoard();
        public string userInput;
        public string player1Move;
        public string player2Move;
        public int scoreMax = 2;
        public string currentRoundWinner;
        public string gameWinner;
        public int numberOfComputers;
        
        // Member Methods (CAN DO)

        public void RunGame()
        {
            // "Master Method"
            this.PickGameMode();
            do
            {
                player1Move = player1.MakeMove(numberOfComputers);
                if(numberOfComputers == 2)
                {
                    Console.ReadLine();
                }
                else if(numberOfComputers == 0)
                {
                    Console.Clear();
                }
                player2Move = player2.MakeMove(numberOfComputers);
                if (numberOfComputers == 2)
                {
                    Console.ReadLine();
                }
                else if(numberOfComputers == 0)
                {
                    Console.Clear();
                }
                currentRoundWinner = this.DecideRoundWinner(player1Move, player2Move);
                scoreBoard.DisplayMoves(player1.name, player2.name, player1Move, player2Move);
                this.AddPointToRoundWinner(currentRoundWinner);
                scoreBoard.DisplayScore(player1.name, player2.name);
            }
            while (scoreBoard.player1Score < scoreMax && scoreBoard.player2Score < scoreMax);
            gameWinner = this.DetermineGameWinner(scoreBoard.player1Score, scoreBoard.player2Score);
            this.DisplayGameWinner(gameWinner);
            this.AskToPlayAgain();
        }

        public void PickGameMode()
        {
            Console.WriteLine("\r\n" + "Welcome To: Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("Press '1' For Single-Player, '2' For Multi-Player, Or '3' For A Show Down Between Computers");
            userInput = Console.ReadLine();
            if(userInput == null)
            {

            }
            bool correctMode = (userInput == "1" || userInput == "2" || userInput == "3");
            do
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("\r\n" + "Please Enter Your Name:");
                        player1 = new Human(Console.ReadLine());
                        player2 = new Computer("Computer");
                        numberOfComputers = 1;
                        break;
                    case "2":
                        Console.WriteLine("\r\n" + "Player 1, Please Enter Your Name:");
                        player1 = new Human(Console.ReadLine());
                        Console.WriteLine("\r\n" + "Player 2, Please Enter Your Name:");
                        player2 = new Human(Console.ReadLine());
                        numberOfComputers = 0;
                        break;
                    case "3":
                        player1 = new Computer("Computer1");
                        player2 = new Computer("Computer2");
                        numberOfComputers = 2;
                        break;
                    default:
                        Console.WriteLine("\r\n" + "Please Try Again With The Described Game Modes");
                        Console.WriteLine("\r\n" + "Press '1' for Single-Player, '2' for Multi-Player, or '3' for A Show Down Between Computers.");
                        break;
                }
            }
            while (correctMode == false);
        }

        public string DecideRoundWinner(string player1Move, string player2Move)
        {
            string roundWinner = "null";

            switch (player1Move)
            {
                case "rock":
                    switch (player2Move)
                    {
                        case "rock":
                            roundWinner = "null";
                            break;
                        case "paper":
                            roundWinner = "player2";
                            break;
                        case "scissors":
                            roundWinner = "player1";
                            break;
                        case "lizard":
                            roundWinner = "player1";
                            break;
                        case "spock":
                            roundWinner = "player2";
                            break;
                    }
                    break;
                case "paper":
                    switch (player2Move)
                    {
                        case "rock":
                            roundWinner = "player1";
                            break;
                        case "paper":
                            roundWinner = "null";
                            break;
                        case "scissors":
                            roundWinner = "player2";
                            break;
                        case "lizard":
                            roundWinner = "player2";
                            break;
                        case "spock":
                            roundWinner = "player1";
                            break;
                    }
                    break;
                case "scissors":
                    switch (player2Move)
                    {
                        case "rock":
                            roundWinner = "player2";
                            break;
                        case "paper":
                            roundWinner = "player1";
                            break;
                        case "scissors":
                            roundWinner = "null";
                            break;
                        case "lizard":
                            roundWinner = "player1";
                            break;
                        case "spock":
                            roundWinner = "player2";
                            break;
                    }
                    break;
                case "lizard":
                    switch (player2Move)
                    {
                        case "rock":
                            roundWinner = "player2";
                            break;
                        case "paper":
                            roundWinner = "player1";
                            break;
                        case "scissors":
                            roundWinner = "player2";
                            break;
                        case "lizard":
                            roundWinner = "null";
                            break;
                        case "spock":
                            roundWinner = "player1";
                            break;
                    }
                    break;
                case "spock":
                    switch (player2Move)
                    {
                        case "rock":
                            roundWinner = "player1";
                            break;
                        case "paper":
                            roundWinner = "player2";
                            break;
                        case "scissors":
                            roundWinner = "player1";
                            break;
                        case "lizard":
                            roundWinner = "player2";
                            break;
                        case "spock":
                            roundWinner = "null";
                            break;
                    }
                    break;
                default:
                    roundWinner = "Invalid Input";
                    break;
            }
            return roundWinner;
        }

        public void AddPointToRoundWinner(string roundWinner)
        {
            if(roundWinner == "player1")
            {
                scoreBoard.AddPointPlayer1();
            }
            else if(roundWinner == "player2")
            {
                scoreBoard.AddPointPlayer2();
            }
        }

        public void AskToPlayAgain()
        {
            Console.WriteLine("\r\n" + "Would You Like To Play Again?");
            if(Console.ReadLine().ToLower() == "yes")
            {
                Game newGame = new Game();
                newGame.RunGame();
            }
            else
            {
                Console.WriteLine("\r\n" + "Thank's For Playing");
                Console.ReadLine();
            }
        }

        public string DetermineGameWinner(int player1Score, int player2Score)
        {
            if(player1Score == scoreMax)
            {
                return player1.name;
            }
            else
            {
                return player2.name;
            }
        }

        public void DisplayGameWinner(string gameWinner)
        {
            Console.WriteLine("\r\n" + "Congratulations, " + gameWinner + ", You've Won!");
        }
    }
}
