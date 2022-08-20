/*
Задайте массив. Напишите функцию, которая определяет, присутствует ли заданное число в массиве.
решать без встроенных функций
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
bool NewMethod(int[] array, int digit)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (digit == array[i])
        {
            return true;
        }
    }
    return false;
}

int[] array = { 6, 7, 19, 345, 3 };
int digit = 3;

bool f = NewMethod(array, digit);
Console.WriteLine(f);
