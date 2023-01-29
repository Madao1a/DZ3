// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int [] numbers = new int[123];
int count = 0;
for (int i = 10; i <= 99; i++)
{
    count = count+1;
}
Console.WriteLine (count*2);


