// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Clear();
// int i = Message ("Введите число");

// int Message (string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }


// Console.WriteLine(Convert.ToString(i, 2));

int InPutNum(string message) // ввод данных
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

int a = InPutNum("Введите число");
int res = 0;
string showresult = string.Empty;
while (a > 0)
{
res = a % 2;
a /= 2;
showresult = res + showresult;
}
Console.WriteLine();
Console.WriteLine(showresult);