

var numbers = new List<int> { 1, 3, 4, 5, 5 , -2, -24, 44, 20 };
var calculator = new Calculator();
Calculator calculatorNew = new CalculateEvenSum();

Console.WriteLine(calculator.CalculateSum(numbers));
Console.WriteLine(calculatorNew.CalculateSum(numbers));


public class Calculator
{
    public Calculator()
    {
        Console.WriteLine("Calculator");
    }
    public int CalculateSum(List<int> _numbers)
    {
        int sum = 0;

        foreach (int number in _numbers)
        {
            if (ShouldAdd(number))
            {
                sum += number;
            }
        }

        return sum;
    }

    protected virtual bool ShouldAdd(int number)
    {
        return true;
    }
} 


public class CalculateEvenSum : Calculator
{
    public CalculateEvenSum()
    {
        Console.WriteLine("Calculator even");
    }
    protected override bool ShouldAdd(int number)
    {
        return number % 2 == 0;
    }
}