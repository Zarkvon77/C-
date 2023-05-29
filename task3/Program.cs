// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int FindFirstDigit(int num)
{
    int firstNumber = num / 100;
    return firstNumber;
}
int FindSecondDigit(int num)
{
    int secondNumber = num % 10;
    return secondNumber;
}

void E(int num, int firstNumber, int secondNumber)
{
    Console.WriteLine("Случайное число "+ num);
    Console.Write(firstNumber);
    Console.Write(secondNumber);
}

int number = new Random().Next(100, 1000);
E(number, FindFirstDigit(number), FindSecondDigit(number));