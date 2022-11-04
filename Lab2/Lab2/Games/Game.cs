using System;
using Lab2.Accounts;

namespace Lab2.Games
{
    
    /**
     * Базовий тип гри
     */
    public abstract class Game
    {
        
        protected  static Random Random = new Random();
        
        protected  static int GamesCount = 0;
        public int Rating { get; }
        public string Name1 { get; }
        public string Name2 { get; }
        public string WinnerName { get; }

        public int Id { get; }

        public Game(string name1, string name2, int rating, string winnerName)
        {
            Rating = rating;
            Name1 = name1;
            Name2 = name2;
            WinnerName = winnerName;

            Id = GamesCount;
            GamesCount++;
        }

        public abstract int GetLostRating();
        
        public abstract int GetWonRating();
        
        public static void ImitationGame(GameAccount player1, GameAccount player2, int rating, GameType type)
        {
            if (Random.Next(0, 2) == 1)
            {
                Game game = GameFabric.CreateGame(type, player1.UserName, player2.UserName, rating, player1.UserName);

                player1.WinGame(game);
                player2.LoseGame(game);
            }
            else
            {
                Game game = GameFabric.CreateGame(type ,player1.UserName, player2.UserName, rating, player2.UserName);

                player1.LoseGame(game);
                player2.WinGame(game);
            }
        }
    }
}