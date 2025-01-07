namespace DiceGame.Game
{
    public class Player
    {
        public string Name { get; private set; }
        public Player(string name)
        {
            Name = name;
        }

        public int PlayTurn(string message)
        {   
            while (true)
            {
                Console.Write("\n" + message);
                var input = Console.ReadLine();

                if (int.TryParse(input, out int guessedNum))
                {
                    return guessedNum;
                }
                Console.WriteLine("Incorrect input");
            }
        }
    }
}