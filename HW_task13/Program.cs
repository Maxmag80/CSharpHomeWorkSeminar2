// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Pls, input integer number:");

int num = Convert.ToInt32(Console.ReadLine());

int num3 = 1;

if (num / 100 >= 1)
{
    while (num / 100 >= 1)
    {
        num3 = num % 10; 
        num = num / 10;
    }
    Console.WriteLine($"third number is: {num3}.");
}
else
    Console.WriteLine("there is not third number.");