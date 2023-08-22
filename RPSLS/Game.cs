using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;
        

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine(" Rock beats scissors \n Scissors beats paper \n Paper covers rock \n Lizard poisons Spock \n Spock smashes scissors \n Scissors decapitates lizard \n Lizard eats paper \n Paper disproves Spock \n Spock vaporizes Rock");





        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("\n How many people are playing? (1 or 2)");
            int numberOfPlayers;
            while (!int.TryParse(Console.ReadLine(), out numberOfPlayers) || (numberOfPlayers != 1 && numberOfPlayers != 2))
            {
                Console.WriteLine("Invalid input! Please enter 1 or 2.");
            }
            
            return numberOfPlayers;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if(numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Player One what is your name?");
                string playerName = Console.ReadLine();
                playerOne = new Human(playerName);
                playerTwo = new Computer("Computer");

            }
            
            
            else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Player One what is your name?");
                string playerName = Console.ReadLine();
                playerOne = new Human(playerName);

                Console.WriteLine("Player One what is your name?");
                string playerNameTwo = Console.ReadLine();
                playerTwo = new Human(playerNameTwo);
            }
        }

        public void CompareGestures()
        {
            if (playerOne.ChooseGesture == playerTwo.ChooseGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors" ||
                     playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper" ||
                     playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock" ||
                     playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "rock" ||
                     playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "spock" ||
                     playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard" ||
                     playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard" ||
                     playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "spock" ||
                     playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper" ||
                     playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "scissors")
            {
                Console.WriteLine("Player One wins! \n");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("Player Two wins! \n");
                playerTwo.score++;
            }
        }

        public void DisplayGameWinner()
        {
            if(playerOne.score == 3)
            {
                Console.WriteLine("Player One is the winner!");
            }
            else if(playerTwo.score == 3)
            {
                Console.WriteLine("Player Two is the winner!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();

            CreatePlayerObjects(ChooseNumberOfHumanPlayers());

            while(playerOne.score != 3 && playerTwo.score != 3)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                CompareGestures();

                
            }
            DisplayGameWinner();
        
        
        
        
        
        
        
        
        
        
        }
    }
}
