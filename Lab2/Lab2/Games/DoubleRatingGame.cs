namespace Lab2.Games
{
    /**
     * Тип гри з подвійним рейтингом. Післе цієї гри знімається та додається подвійна кількість рейтингу
     */
    public class DoubleRatingGame : Game
    {
        public DoubleRatingGame(string name1, string name2, int rating, string winnerName) : base(name1, name2, rating, winnerName)
        {
        }

        public override int GetLostRating()
        {
            return Rating * 2;
        }

        public override int GetWonRating()
        {
            return Rating * 2;
        }
        
        public override string ToString()
        {
            return "\nGame id: " + Id + "\nGame type: double rating\nFirst player name : " + Name1 +
                   "\nSecond player name : " + Name2
                   + "\nRating : " + Rating + "\nWinner : " + WinnerName;
        }
    }
}