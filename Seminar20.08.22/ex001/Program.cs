﻿/*
Задача 32: Напишите функцию замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] array = new int[] {-4, -8, 8, 2};

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}
    string str = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        str = str + Convert.ToString(array[i]) + " ";
    }
    Console.Write(str);