// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] numbers = new int[33];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]=rand.Next(1,20);
}
int size = numbers.Length - 1;
for (int j = 0; j < numbers.Length; j++)
{
    int res = numbers[j]*numbers[size];
    Console.WriteLine (res);
    size=size-1;
}