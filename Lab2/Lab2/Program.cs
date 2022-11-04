using Lab2.Accounts;
using Lab2.Games;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var player1 = new MGameAccount("x2");
            var player2 = new LGameAccount("lost/2");

            Game.ImitationGame(player1, player2, 10, GameType.Standard);
            Game.ImitationGame(player1, player2, 10, GameType.Train);
            Game.ImitationGame(player1, player2, 10, GameType.DoubleRating);
            
            player1.GetStats();
            player2.GetStats();
        }
    }
}