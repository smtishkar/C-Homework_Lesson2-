// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.Clear();
Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99)
{
    String number_text = (number).ToString();
    int strLen = number_text.Length;
    // Console.WriteLine(strLen);
    int i = strLen - 2;
    // Console.WriteLine(i);
    double a = Math.Pow(10, i);
    // Console.WriteLine(a);
    int b = Convert.ToInt32 (number % a);
    int c = Convert.ToInt32 (a / 10);
    Console.WriteLine (b/c);
}
else
{
    Console.Write("Третьей цифры нет");
}





// Иной способ решения, просто конвертируя значение в строку и нахождение элемента с индексом 2
// if (number > 99)
// {
//     String text = (number).ToString();
//     Console.Write(text[2]);
// }
// else
// {
//     Console.Write("Третьей цифры нет");
// }