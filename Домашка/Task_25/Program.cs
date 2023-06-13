// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int x = 5;
// int stepen = 3;
// Console.WriteLine("5^3 = " + Math.Pow(x, stepen));

int Prompt (string message) {
Console.Write(message);
int num = int.Parse(Console.ReadLine()!);
return num;
}

int a = Prompt("Введите число a:");
int b = Prompt("Введите число b:");
Console.WriteLine("a^b = " + Math.Pow(a, b));