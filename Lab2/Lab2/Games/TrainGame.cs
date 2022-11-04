namespace Lab2.Games
{
    /**
     * Тренувальний тип гри. Рейтинг після цієї гри не змінюється
     */
    public class TrainGame : Game
    {
        public TrainGame(string name1, string name2, int rating, string winnerName) : base(name1, name2, rating, winnerName)
        {
        }
        
        public override int GetLostRating()
        {
            return 0;
        }

        public override int GetWonRating()
        {
            return 0;
        }
        
        public override string ToString()
        {
            return "\nGame id: " + Id + "\nGame type: train\nFirst player name : " + Name1 +
                   "\nSecond player name : " + Name2
                   + "\nRating : " + Rating + "\nWinner : " + WinnerName;
        }
    }
}