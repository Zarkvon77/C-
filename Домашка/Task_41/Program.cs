// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
int size = Prompt("Введите количество чисел: ");
int[] array = new int[size];

int Prompt(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int x = 0;
int count = 0;
while (x < size)
{
    if (Prompt($"Введите {1 + x} число: ") > 0)
    {
        count += 1;
    }
    x++;
}

Console.WriteLine($"Колличество положительных чисел равно: {count}");





