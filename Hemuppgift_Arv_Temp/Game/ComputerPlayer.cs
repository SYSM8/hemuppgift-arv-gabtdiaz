using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer(Board board) : base ("Dator", board) {} 

        public override void TakePins()
        {
            Random random = new Random();

            // slumpar fram ett tal mellan 1-2
            int pinsTaken = random.Next(1, 3);

            // kontrollerar antalet dragna pinnar
            board.TakePins(pinsTaken);

            // Skriver ut antalet pinnar som är kvar
            Console.WriteLine($"Datorn tog {pinsTaken} pinnar. Pinnar kvar: {board.GetNoPins()}.");
        }
    }
}
