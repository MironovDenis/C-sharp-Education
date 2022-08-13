int x = new Random().Next(-10, 10);
int y = new Random().Next(-10, 10);
Console.WriteLine($"Координата х = {x}");
Console.WriteLine($"Координата y = {y}");

while(x != 0 | y != 0)
{
    if(x > 0 && y > 0)
    {
        Console.WriteLine("Первая четверть"); 
           }   

    if(x < 0 && y > 0)
    {
        Console.WriteLine("Вторая четверть");
            }

    if(x < 0 && y < 0)
    {
        Console.WriteLine("Третья четверть");
           }

    if(x > 0 && y < 0)
    {
        Console.WriteLine("Четвертая четверть");
            }
break;
}