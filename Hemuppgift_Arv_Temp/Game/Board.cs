using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        // Egenskaper
        private int NoPins { get; set; }

        // Metod som sätter värdet av NoPins
        public string SetUp()
        {
            Random random = new Random();
            this.NoPins = random.Next(10, 16);
            return $"Antalet pinnar i spel: {NoPins}";
        }
        // Metod som returnerar värdet av NoPins
        public virtual int GetNoPins()
        {
            return NoPins;
        }

        // Metod som kontrollerar antalet tagna pinnar
        public void TakePins(int pinsTaken)
        {
            if (pinsTaken >= 1 && pinsTaken <= 2 && NoPins >= pinsTaken)
            {
                NoPins -= pinsTaken;
            }
            else
            {
                Console.WriteLine("Felaktig inmatning. Du får ta 1 eller 2 pinnar och inte mer än antalet som är kvar.");
            }
        }
    }
}
