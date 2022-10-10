namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GameAccount player1 = new GameAccount("player1");
            GameAccount player2 = new GameAccount("player2");
            
            Game.imitationGame(player1, player2, 30);
            Game.imitationGame(player1, player2, 50);
            Game.imitationGame(player1, player2, 10);
            
            player1.GetStats();
            player2.GetStats();
        }
    }
}