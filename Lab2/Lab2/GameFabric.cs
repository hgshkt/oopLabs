using System;
using Lab2.Games;

namespace Lab2
{
    public static class GameFabric
    {
        public static Game CreateGame(GameType type, string name1, string name2, int rating, string winnerName)
        {
            switch (type)
            {
                case GameType.Standard:
                    return new StandardGame(name1, name2, rating, winnerName);
                case GameType.Train:
                    return new TrainGame(name1, name2, rating, winnerName);
                case GameType.DoubleRating:
                    return new DoubleRatingGame(name1, name2, rating, winnerName);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}