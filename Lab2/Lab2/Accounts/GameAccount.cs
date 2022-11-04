using System;
using System.Collections.Generic;
using Lab2.Games;

namespace Lab2.Accounts
{
    public class GameAccount
    {
        public string UserName { get; }
        protected int CurrentRating = 100, GamesCount = 0;
        public List<Game> Games = new List<Game>();

        public GameAccount(string userName)
        {
            UserName = userName;
        }

        public virtual void WinGame(Game game)
        {
            GamesCount++;
            Games.Add(game);
            CurrentRating += game.GetWonRating();
        }

        public virtual void LoseGame(Game game)
        {
            GamesCount++;
            Games.Add(game);
            if (CurrentRating - game.GetLostRating() < 0)
            {
                CurrentRating = 0;
            }

            CurrentRating -= game.GetLostRating();
        }

        public void GetStats()
        {
            Console.WriteLine("\nPlayer name : " + UserName + "\nGames count: " + GamesCount + "\nCurrent rating : " +
                              CurrentRating + "\nGame list :");
            
            foreach (Game game in Games)
            {
                Console.WriteLine(game.ToString());
            }
        }
    }
}