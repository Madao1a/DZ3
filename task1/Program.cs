﻿/*Найти кубы чисел от 1 до N
Найти сумму чисел от 1 до А
Возведите число А в натуральную степень B используя цикл
Подсчитать сумму цифр в числе
Написать программу вычисления произведения чисел от 1 до N
Показать кубы чисел, заканчивающихся на четную цифру
Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Определить, присутствует ли в заданном массиве, некоторое число
Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Найти сумму чисел одномерного массива стоящих на нечетной позиции
Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом*/

// Найти кубы чисел от 1 до N
Console.WriteLine ("Введите число N ");
int N = int.Parse (Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    int cub = i*i*i;
    Console.WriteLine (cub);
}
