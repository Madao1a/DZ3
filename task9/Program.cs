// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] nambers = new int[6];
Random rand = new Random();
for (int i = 0; i < nambers.Length; i++)
{
    nambers[i] = rand.Next(100,999);
    Console.WriteLine (nambers[i]);
}
int countY = 0;
int countN = 0;
for (int j = 0; j < nambers.Length; j++)
{
    if (nambers[j]%2==0)
    {
        countY=countY+1;
    }
    else
    {
        countN=countN+1;
    }
}
Console.WriteLine ("Количество четных числел ="+ countY);
Console.WriteLine ("Количество четных числел ="+ countN);