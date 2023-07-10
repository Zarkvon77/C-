// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int Message(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int x = Message("Введите сторону a:");
int y = Message("Введите сторону b:");
int z = Message("Введите сторону c:");

void Triangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Такой треугольник существует");
    }
    else
    {
        Console.WriteLine("Такой треугольник не существует");
    }
}

Triangle(x, y, z);