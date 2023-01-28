// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine ("Введите число N ");
int numbers = int.Parse (Console.ReadLine());
for (int i = 1; i<=numbers ; i++)
{
    if (i%2==0)
    {
        Console.WriteLine (i*i*i);
    }
}
