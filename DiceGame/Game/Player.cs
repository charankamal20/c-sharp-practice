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
            int guessedNum = 0;

            while (true)
            {
                Console.Write("\n" + message);
                var input = Console.ReadLine();

                if (int.TryParse(input, out guessedNum) && guessedNum > 0 && guessedNum <= 6)
                {
                    return guessedNum;
                }
                Console.WriteLine("Incorrect input");
            }
        }
    }
}