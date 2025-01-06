//for 문을 이용한 홀수 출력
Console.WriteLine("for 문을 이용한 홀수 출력");

for (int i = 0; i <= 100; i++)
{
  if (i % 2 == 0) continue;
  Console.WriteLine(i);
}

//while 문을 이용한 홀수 출력
Console.WriteLine("while 문을 이용한 홀수 출력");

int j = 0;
while (j <= 100)
{
  if ((j % 2) != 0) Console.WriteLine(j);
  j++;
}

//do-while 문을 이용한 홀수 출력
Console.WriteLine("do-while 문을 이용한 홀수 출력");

int k = 0;
do
{
  if ((k % 2) != 0) Console.WriteLine(k);
  k++;
 }
while (k <= 100);
