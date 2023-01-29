// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] numbers = new int[33];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]=rand.Next(1,100);
}
int sum = 0;
for (int j = 0; j < numbers.Length; j++)
{
    if (j%2!=0)
    {
        sum=sum+numbers[j];
    }
}
Console.WriteLine (sum);