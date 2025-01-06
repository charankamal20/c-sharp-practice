namespace DiceGame.Game;
public class Dice
{
    private static readonly Random _random = new Random();
    public readonly int NumOfSides;

    public Dice(int numOfSides = 6)
    {
        NumOfSides = numOfSides;
    }

    public int ThrowDice() => _random.Next(1, NumOfSides + 1);
}
