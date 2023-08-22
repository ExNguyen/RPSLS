using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Human : Player
    {
        public Human(string name) : base(name)
        {
        
        }

        public override void ChooseGesture()
        {
            Console.WriteLine($"{name}, choose your gesture (Rock, Paper, Scissors, Lizards, Spock)");
            chosenGesture = Console.ReadLine().ToLower();
            while (chosenGesture != "rock" && chosenGesture != "paper" && chosenGesture != "scissors" && chosenGesture != "lizard" && chosenGesture != "spock")
            {
                Console.WriteLine("Invalid choice. Please choose again.");
                chosenGesture = Console.ReadLine().ToLower();
            }
        }
    }
}
