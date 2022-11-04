using Lab2.Games;

namespace Lab2.Accounts
{
    
    /**
     * Акаунт цього типу отримує та втрачає в 2 рази більше рейтингу
     */
    public class MGameAccount : GameAccount
    {
        public MGameAccount(string userName) : base(userName)
        {
        }

        public override void LoseGame(Game game)
        {
            GamesCount++;
            Games.Add(game);
            if (CurrentRating - game.GetLostRating() * 2 < 0)
            {
                CurrentRating = 0;
            }

            CurrentRating -= game.GetLostRating() * 2;
        }

        public override void WinGame(Game game)
        {
            GamesCount++;
            Games.Add(game);
            CurrentRating += game.GetWonRating() * 2;
        }
    }
}