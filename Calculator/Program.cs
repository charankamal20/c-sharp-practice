
while (true)
{
    Console.WriteLine("Welcome to the Calculator App\n");
    
    Console.Write("Enter the first number: ");
    string input = Console.ReadLine();
    int num1 = int.Parse(input);

    Console.Write("Enter the second number: ");
    input = Console.ReadLine();
    int num2 = int.Parse(input);

    Console.WriteLine("Choose an option: ");
    Console.WriteLine("[A]dd a number");
    Console.WriteLine("[S]ubtract a number");
    Console.WriteLine("[M]ultiply a number");

    Console.Write("Your option: ");   
    input = Console.ReadLine();

    int result = 0; 
    switch(input.ToLower())
    {
        case "a":
            result = num1 + num2;
            PrintResultEquation(num1, num2, "+", result);
            break;

        case "s":
            result = num1 - num2;
            PrintResultEquation(num1, num2, "-", result);
            break;

        case "m": 
            result = num1 * num2;
            PrintResultEquation(num1, num2, "*", result);
            break;

        default:
            Console.WriteLine("Invalid Input!\n\n");
            break;
    }

}


void PrintResultEquation(int num1, int num2, string @operator, int result)
{   
    Console.WriteLine($"{num1} {@operator} {num2} = {result}");
}