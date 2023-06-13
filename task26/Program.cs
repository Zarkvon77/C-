// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Digital(int num)
{
int i = 0;
while (num > 0)
{
    num = num/10;
    i = i + 1;
    
}
return i;
}
string mess ="Введите число";
int num = Prompt(mess);
int x = Digital(num);
Console.WriteLine(x);