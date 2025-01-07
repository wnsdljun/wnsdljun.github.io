//구구단출력

//세로로
for (int i = 1;  i <= 9;  i++)
{
    for(int j = 2;  j <= 9; j++)
    {
        Console.Write($"{j} x {i} = {i*j}\t");
    }
    Console.WriteLine();
}

//가로로
for (int i = 2; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.Write($"{i} x {j} = {i * j}\t");
    }
    Console.WriteLine();
}
