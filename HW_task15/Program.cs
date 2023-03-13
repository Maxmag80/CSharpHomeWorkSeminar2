// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Pls, input day of the week number:");
int numDay = Convert.ToInt32(Console.ReadLine());

if (numDay >=1 && numDay <= 7)
{
    if (numDay == 6 || numDay == 7)

        Console.WriteLine("Yes, its a Weekend! Yo-hooo!");

    else

        Console.WriteLine ("Its a not weekend. Hold on!");
}
else

        Console.WriteLine("Pls, input correct day number - from 1 to 7");
