//Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine ("Введите число N ");
int N = int.Parse (Console.ReadLine());
int res = 1;
for (int i = 1; i <= N ; i++)
{
    res=res*i;
}
Console.WriteLine (res);