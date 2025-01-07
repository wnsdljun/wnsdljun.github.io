//팩토리얼 계산
int input;
while (true)
{
    Console.Write("Enter a number: ");
    try
    {
        input = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("입력은 숫자여야 하며 비워둘 수 없습니다.");
        continue;
    }
    if (input < 0)
    {
        Console.WriteLine("입력은 음수가 될 수 없습니다.");
        continue;
    }
    break;
}

//팩토리얼은 입력 숫자가 조금만 커져도 int, 심지어 ulong 타입도 부족하다. Biginteger 구조체로 표현
BigInteger factorial = 1;
for (int i = 1; i <= input; i++)
{
    factorial = factorial * i;
}
Console.WriteLine($"Factorial of {input} is {factorial}");
