//숫자 맞추기 게임

Random rnd = new Random(DateTime.Now.Microsecond);
int number = rnd.Next(1,101);

int input;
while (true)
{
    Console.Write("Enter your guess (1-100): ");
    try
    {
        input = int.Parse(Console.ReadLine());
    }
    catch 
    {
        Console.WriteLine("You can enter only \"NUMBER\".");
        continue;
    }
    if (input < 1 || input > 100)
    {
        Console.WriteLine("Value out of range, must be 1-100.");
        continue;
    }
    if (input == number)
    {
        Console.WriteLine("Congratulations! You guessed the number.");
        break;
    }
    else if (input > number)
    {
        Console.WriteLine("Too high! Try again.");
        continue;
    }
    else if (input < number)
    {
        Console.WriteLine("Too low! Try again.");
        continue;
    }
    else
    {
        Console.WriteLine("???");
        break;
    }
}
