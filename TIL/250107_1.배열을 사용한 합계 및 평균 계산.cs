//주어진 배열
int[] numbers = { 10, 20, 30, 40, 50 };

//배열의 합
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

//배열의 평균
float average = sum / numbers.Length;

//출력
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {average}");

Console.WriteLine($"sum: {numbers.Sum()}, average: {numbers.Average()}");
