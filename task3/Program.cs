//Возведите число А в натуральную степень B используя цикл
Console.WriteLine ("Введите число A ");
int A = int.Parse (Console.ReadLine());
Console.WriteLine ("Введтие число B");
int B = int.Parse (Console.ReadLine());
int Res = 1;
for (int i = 0; i < B; i++)
{
    
    Res =Res * A;
}
Console.WriteLine (Res);