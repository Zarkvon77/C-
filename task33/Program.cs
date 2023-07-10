// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();

int Message(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int[] RandomMassive(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1, 6);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int x = Message("Ведите размер массива:");
int y = Message("Ведите искомое число:");
int[] array = RandomMassive(x);
PrintArray(array);




bool k = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == y)
    {
        k = true;
        break;
    }

}

if (k == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}


// int[] massiv = { 6, 7, 19, 345, 3 };
// void FindNum(int[] array, int x)
// {
// int i = 0;
// int length = array.Length;
// bool flag = false;
// while (i < length)
// {

// if (x == array[i])
// {
// flag = true;
// }
// i++;
// }
// if (flag) {
// Console.WriteLine($"Цифра {x} имеется в массиве");

// }
// else {
// Console.WriteLine($"Цифра {x} нет в массиве");
// }
// }
// Console.WriteLine(string.Join(", ", massiv));
// FindNum(massiv, 345);