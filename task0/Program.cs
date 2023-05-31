//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
//на само себя).

//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int result = number * number;
Console.WriteLine("Квадрат числа равен " + result);


 for (int i = 2; i <= 10; i++)
 {
        for (int j = 2; j <= 10; j++)
        {
            Console.WriteLine($"{i} x {j} = {i * j}");
        }
        Console.WriteLine();
    }