// Определить, присутствует ли в заданном массиве, некоторое число
int[] numbers = new int[5];
Random rand = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(1,20);
    Console.WriteLine (numbers[i]);  
}
Console.WriteLine ("Введите число A ");
int A = int.Parse (Console.ReadLine());
for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] == A)
    {
        Console.WriteLine ("Заданное число присутствует в " + j);
    } 
}
