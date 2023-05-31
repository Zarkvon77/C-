// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Number()
{Console.WriteLine("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine());
return num;
}
 int  x = Number();
void Digital()
{
int x1 = x/10000;
int x2 = x/1000%10;
int x3 = x/100%10;
int x4 = x/10%10;
int x5 = x%10;
if (x1 == x5 && x2 == x4)
{
    Console.WriteLine($"Число {x} является палиндромом");
}
else
{
    Console.WriteLine($"Число {x} не палиндром");
}
}

Digital();





