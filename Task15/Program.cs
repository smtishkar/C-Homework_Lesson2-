// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.Write("Это выходной день");
}

else if (number < 6 && number > 0)
{
    Console.Write("Это рабочий день");
}

else
{
    Console.Write("Такого дня не бывает");
}