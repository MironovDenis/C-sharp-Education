/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/ 

Random rnd = new Random();
double x1 = rnd.Next(-100, 100)/10d;
Console.WriteLine($"x1= {x1}");
double y1 = rnd.Next(-100, 100)/10d;
Console.WriteLine($"y1= {y1}");
double x2 = rnd.Next(-100, 100)/10d;
Console.WriteLine($"x2= {x2}");
double y2 = rnd.Next(-100, 100)/10d;
Console.WriteLine($"y2= {y2}");
double dist = 0;

dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между двумя точками на плоскости равно {Math.Round(dist, 3)}");


/* Random rnd = new Random();
            double d =rnd.Next(-1000, 1000)/100d;
            Console.WriteLine(d);*/ 