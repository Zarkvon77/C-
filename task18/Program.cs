// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)

int x1 = Prompt("Введите  номер четверти: ");
ShowQuarter(x1);



int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
void FindCoordinate(int x)
{
    if (x == 1)
    {
        Console.WriteLine("x>0, y>0");
    }
    if (x == 2)
    {
        Console.WriteLine("x<0, y>0");
    }
    if (x == 3)
    {
        Console.WriteLine("x<0, y<0");
    }
    if (x == 4)
    {
        Console.WriteLine("x>0, y>0");
    }
}


void ShowQuarter (int x1) {

if (x1 <1 || x1 >4) {

Console.WriteLine("Введена не правильная четверть");
}
else {
FindCoordinate (x1);
}
}
    
