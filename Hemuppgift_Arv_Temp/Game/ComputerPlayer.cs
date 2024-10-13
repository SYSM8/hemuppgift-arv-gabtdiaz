using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class ComputerPlayer : Player
    {
        // Konstruktor som hämtar metod från Board-klassen och sätter namnet på ComputerPlayer
        public ComputerPlayer(Board board) : base ("Dator", board) {} 

        public override void TakePins()
        {
            // Hämtar antalet pinnar kvar
            int pinsLeft = board.GetNoPins();
            int pinsTaken;

            // Datorn väljer pinnar beroende på antalet pinnar som finns kvar
            // Om antalpinnar är en multipel av 3 tar datorn antingen 1-2 pinnar.
            if (pinsLeft % 3 == 0)
            {
                // Slumpar fram ett tal mellan 1-2
                Random random = new Random();
                pinsTaken = random.Next(1, 3);
            }
            // Annars väljer datorn att ta pinnar så att antal pinnar kvar blir en multipel av 3.
            else
            { 
                pinsTaken = pinsLeft % 3; 
            }

            // Kontrollerar antalet dragna pinnar
            board.TakePins(pinsTaken);

            // Skriver ut antalet pinnar som är kvar
            Console.WriteLine($"Datorn tog {pinsTaken} pinnar. Pinnar kvar: {board.GetNoPins()}.");
        }
    }
}
