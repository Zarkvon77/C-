// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int x1 = Prompt("Введите координату x: ");
int y1 = Prompt("Введите координату y: ");
FindCoordinate(x1, y1);


int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
void FindCoordinate(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("I четверть");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine("II четверть");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine("III четверть");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine("IV четверть");
    }
}