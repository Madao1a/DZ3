//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] numbers = new double[10];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]= rand.Next(1,6);
    Console.WriteLine (numbers[i]);
}
double min=numbers[1];
double max=numbers[1];
for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j]>max)
    {
        max=numbers[j];
    }
    if (numbers[j]<min)
    {
        min=numbers[j];
    }
}
Console.WriteLine (max-min);