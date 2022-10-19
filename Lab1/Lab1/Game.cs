using System;

namespace Lab1
{
    public class Game
    {
        private static Random Random = new Random();

        private static int GamesCount = 0;
        public int Rating { get; }
        public string Name1 { get; }
        public string Name2 { get; }
        public string WinnerName { get; }

        public int id { get; }

        public Game(string name1, string name2, int rating, string winnerName)
        {
            Rating = rating;
            Name1 = name1;
            Name2 = name2;
            WinnerName = winnerName;

            id = GamesCount;
            GamesCount++;
        }

        public static void imitationGame(GameAccount player1, GameAccount player2, int rating)
        {
            if (Random.Next(0, 2) == 1)
            {
                Game game = new Game(player1.UserName, player2.UserName, rating, player1.UserName);
                player1.games.Add(game);
                player2.games.Add(game);

                player1.WinGame(player2.UserName, rating);
                player2.LoseGame(player1.UserName, rating);
            }
            else
            {
                Game game = new Game(player1.UserName, player2.UserName, rating, player2.UserName);
                player1.games.Add(game);
                player2.games.Add(game);

                player1.LoseGame(player2.UserName, rating);
                player2.WinGame(player1.UserName, rating);
            }
        }
    }
}