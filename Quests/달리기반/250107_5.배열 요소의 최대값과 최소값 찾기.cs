//최대 최소
//주어진 배열
int[] numbers = { 10, 20, 30, 40, 50 };
int min = numbers[0];
int max = numbers[0];

for (int i = 0;  i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine($"Min: {min}, Max: {max}");
Console.WriteLine($"Min: {numbers.Min()}, Max: {numbers.Max()}");
