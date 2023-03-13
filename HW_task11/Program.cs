// Задача 11 - HARD На входе от пользователя целое число любой разрядности, надо удалить вторую цифру слева направо этого числа.
Console.WriteLine("Pls, input any integer number:");
int num = Convert.ToInt32(Console.ReadLine());

int origNum = num;
int count = 1;
//int num1 = Math.Abs(num);

if (Math.Abs(num) / 10 >= 1)
{
    while (Math.Abs(num) / 10 >= 1)
    {
        count = count * 10;
        num = num /10;
    }
    int result = num * (count / 10) + origNum % (count / 10);

    Console.WriteLine($"the number without second digit is: {result}.");
}
else
    Console.WriteLine("there is not second digit.");