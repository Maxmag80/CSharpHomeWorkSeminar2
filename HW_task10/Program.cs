// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Pls, input 3-digital number:");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);

if (num / 100 >= 1 && num / 100 < 10)
{
    int secondNum = (num % 100)/10;
    Console.WriteLine($"Second number is: {secondNum}");
}
else
    Console.WriteLine("You entered non 3-digital number.");