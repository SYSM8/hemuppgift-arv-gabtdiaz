using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class HumanPlayer : Player
    { 
        // Konstruktor - Hämtar egenskaper&metoder från Board-klassen och Player-klassen
        public HumanPlayer(string Name, Board board) : base(Name, board) {}

        public override void TakePins()
        {
            {
                // Be spelaren mata in hur många pinnar de ska ta
                Console.WriteLine($"{Name}, ange hur många pinnar du vill ta, 1-2: ");
                int pinsTaken = Convert.ToInt32(Console.ReadLine());

                // Kontrollerar antalet tagna pinnar genom att skicka pinsTaken som parameter.
                board.TakePins(pinsTaken);

                // Skriver ut antalet pinnar som är kvar
                Console.WriteLine($"Pinnar kvar: {board.GetNoPins()}");
            }
        }

    }
}
