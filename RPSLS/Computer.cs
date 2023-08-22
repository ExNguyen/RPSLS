using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Computer : Player
    {
        private Random random;
        public Computer(string name) : base(name)
        {
            random = new Random();
        }

        public override void ChooseGesture()
        {
            int randomNum = random.Next(gestures.Count);
            chosenGesture = gestures[randomNum];
            Console.WriteLine($"Computer chooses: {chosenGesture}");
        }
        
            

    }
}
