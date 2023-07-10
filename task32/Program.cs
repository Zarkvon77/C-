// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные,
//  и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2

int[] RandomMassive(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-100, 101);
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

int[] BackFlip(int[] res)
{
    
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = res[i] * -1;
        
    }
    return res;
    
}


int[] array = RandomMassive(5);
PrintArray(array);
int[] arra = BackFlip(array);
Console.WriteLine(" ");
 PrintArray(arra);
