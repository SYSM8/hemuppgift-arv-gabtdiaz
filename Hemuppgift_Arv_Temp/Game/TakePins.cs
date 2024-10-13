namespace Hemuppgift_Arv_Temp.Game
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            // Skapa nytt spelbräde
            Board board = new Board();

            // Skapa spelare
            string playerName = "";
            Player human = new HumanPlayer(playerName, board);
            playerName = human.GetPlayerName();

            Player computer = new ComputerPlayer(board);

            // Skapa currentPlayer som ska växla mellan de två spelarna
            Player currentPlayer = human;

            // Starta spelet
            Console.WriteLine(board.SetUp());

            // Loop för spel tills antalet pinnar når 0
            while (board.GetNoPins() > 0)
            {
                currentPlayer.TakePins();

                if (board.GetNoPins() == 0)
                {
                    Console.WriteLine($"{currentPlayer.Name} har vunnit!");
                    break; // Loopen avslutas om någon har vunnit
                }
                currentPlayer = (currentPlayer == human) ? computer : human; // Byter spelare
            }
        }
    }
}
