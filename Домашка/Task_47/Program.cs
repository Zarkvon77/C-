// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");




int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] a = new double[rows, columns];

Random random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        a[i, j] = random.NextDouble() * 10; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,5:F1}", a[i, j]);
    }
    Console.WriteLine();
}

