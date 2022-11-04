namespace Lab2.Games
{
    
    /**
     * Стандартний тип гри
     */
    public class StandardGame : Game
    {
        public StandardGame(string name1, string name2, int rating, string winnerName) : base(name1, name2, rating, winnerName)
        {
        }

        public override int GetLostRating()
        {
            return Rating;
        }

        public override int GetWonRating()
        {
            return Rating;
        }
        
        public override string ToString()
        {
            return "\nGame id: " + Id + "\nGame type: standard\nFirst player name : " + Name1 +
                   "\nSecond player name : " + Name2
                   + "\nRating : " + Rating + "\nWinner : " + WinnerName;
        }
    }
}