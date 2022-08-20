﻿/* Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */ 

int n = 123;
int[] array = new int[n];
int value = 0;

for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1, 1000);
    Console.Write(array[i] + " ");
}

for(int i = 0; i < n; i++)
{
    if(array[i] > 9 && array[i] < 100)
    {
        value += 1;
    }
}
Console.WriteLine(" ");
Console.WriteLine($"Число элементов в отрезке от 10 до 99: {value} ");