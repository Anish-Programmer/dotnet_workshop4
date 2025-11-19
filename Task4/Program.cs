namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object of Player class using default constructor
            Player player1 = new Player();
            player1.playerName = "Shiv";
            player1.level = 99;
            player1.health = "Fit";

            // printing the default values of default constructor
            Console.WriteLine("\nPlayer1 details: (default constructor)");
            Console.WriteLine($"Player Name: {player1.playerName}\nLevel: {player1.level}\nHealth: {player1.health}");
          
            // creating object of Player class using parameterized constructor
            Player player2 = new Player("Ram",99,"Good");

            // printing the values of player2 object
            Console.WriteLine("\nPlayer2 details: (parameterized constructor)");
            Console.WriteLine($"Player Name: {player2.playerName}\nLevel: {player2.level}\nHealth: {player2.health}");
        }
    }
}
