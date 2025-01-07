namespace DiceGame.Game
{
    public class GameController
    {
        public int TurnsLeft { get; private set; }
        private readonly Dice _dice;
        private readonly Player _player;

        public GameController(Player player, Dice dice, int tries = 3)
        {
            TurnsLeft = tries;
            _player = player;
            _dice = dice;
        }

        public void Run()
        {
            PrintWelcomeMessage();
            int diceResult = _dice.ThrowDice();

            while (TurnsLeft > 0)
            {
                int guessedNumber = _player.PlayTurn("Enter a Number between " + 1 + "-" + _dice.NumOfSides + ": ");

                if (guessedNumber > 0 && guessedNumber <= _dice.NumOfSides)
                {
                    Console.WriteLine("Incorrect input");
                    continue;
                }

                if (ValidateResults(diceResult, guessedNumber))
                {
                    break;
                }

                Console.WriteLine("Wrong Number");
                TurnsLeft--;
            }

            if (TurnsLeft > 0)
            {
                Console.WriteLine($"You Win {_player.Name}! ^o^");
            }
            else
            {
                Console.WriteLine($"You lose {_player.Name}! ToT");
            }

            Console.ReadKey();
        }

        private static bool ValidateResults(int dice, int guessed) => dice == guessed;

        private void PrintWelcomeMessage()
        {
            Console.WriteLine($"Dice rolled. Guess what number it shows in {TurnsLeft} tries.");
            Console.WriteLine();
        }
    }
}