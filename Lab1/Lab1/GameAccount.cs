using System;
using System.Collections;
using System.Security.AccessControl;

namespace Lab1
{
    public class GameAccount
    {
        public string UserName { get; }
        private int CurrentRating = 100, GamesCount = 0;
        private ArrayList games = new ArrayList();

        public GameAccount(string userName)
        {
            UserName = userName;
        }

        public void WinGame(string opponentName, int rating)
        {
            games.Add(new Game(UserName, opponentName, rating, UserName));
            GamesCount++;

            CurrentRating += rating;
        }

        public void LoseGame(string opponentName, int rating)
        {
            games.Add(new Game(UserName, opponentName, rating, opponentName));
            GamesCount++;
            if (CurrentRating - rating < 0)
            {
                CurrentRating = 0;
                throw new Exception("Rating can't be less than 0");
            }

            CurrentRating -= rating;
        }

        public void GetStats()
        {
            Console.WriteLine("\nPlayer name : " + UserName + "\nCurrent rating : " + CurrentRating + "\nGame list :");
            foreach (Game game in games)
            {
                Console.WriteLine("\nFirst player name : " + game.Name1 + "\nSecond player name : " + game.Name2
                                  + "\nRating : " + game.Rating + "\nWinner : " + game.WinnerName);
            }
        }
    }
}