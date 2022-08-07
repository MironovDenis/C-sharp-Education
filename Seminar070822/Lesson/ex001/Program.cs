// 1. 11. Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

/* int value = new Random().Next(100, 1000);
  int a = value / 100;
  int b = value % 10;
  Console.WriteLine(value);
Console.WriteLine(a);
Console.WriteLine(b);
value = a*10 + b;
Console.WriteLine(value); */

// 12. Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли второе число кратным 
// первому. Если число 2 не кратно числу 1, то программа 
// выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// int a = 34;
// int b = 5;
// int result = a % b;

// if(result==0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
 //    Console.WriteLine("не кратно");
 //    Console.WriteLine(result);
// }


// 14. Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

/* int a = 7;
int b = 23;
int c = new Random().Next(1, 1000);
Console.WriteLine(c);
// int c = 23;
int result1 = c % a;
int result2 = c % b;

if(result1 + result2==0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно");   
} */

