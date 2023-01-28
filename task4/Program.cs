// Подсчитать сумму цифр в числе
Console.WriteLine ("Введие число ");
int A = int.Parse (Console.ReadLine());
int sum = A%10;
for (int i = A; i >= 10 ||i <=-10; i=i/10)
{
    sum =sum + i%10;
}
Console.WriteLine (sum);
