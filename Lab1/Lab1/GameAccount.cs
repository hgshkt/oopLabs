using System;
using System.Collections.Generic;

namespace Lab1
{
    public class GameAccount
    {
        public string UserName { get; }
        private int CurrentRating = 100, GamesCount = 0;
        public List<Game> games = new List<Game>();

        public GameAccount(string userName)
        {
            UserName = userName;
        }
        
        public void WinGame(string opponentName, int rating)
        {
            GamesCount++;
            CurrentRating += rating;
        }

        public void LoseGame(string opponentName, int rating)
        {
            GamesCount++;
            if (CurrentRating - rating < 0)
            {
                CurrentRating = 0;
            }

            CurrentRating -= rating;
        }

        public void GetStats()
        {
            Console.WriteLine("\nPlayer name : " + UserName + "\nCurrent rating : " + CurrentRating + "\nGame list :");
            foreach (Game game in games)
            {
                Console.WriteLine("\nGame id: " + game.id + "\nFirst player name : " + game.Name1 + "\nSecond player name : " + game.Name2
                                  + "\nRating : " + game.Rating + "\nWinner : " + game.WinnerName);
            }
        }
    }
}