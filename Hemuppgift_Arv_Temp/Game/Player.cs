using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player : Board // hanterar spelare
    {
        // Egenskaper
        public string Name { get; set; }
        protected Board board {  get; set; }

        // Ska ärva egenskaperna från Board utan att man ska få direkt tillgång till klassen.
        public Player (string Name, Board board) 
        {
           this.Name = Name;
           this.board = board;
        }

        public virtual string GetPlayerName()
        {
            Console.WriteLine("Ange ditt namn: ");
            Name = Console.ReadLine();
            return Name;
        }

        // Abstrakt metod som varje spelare implementerar
        public abstract void TakePins();
    }
}

