// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
string num = Console.ReadLine();
int day = int.Parse(num);

if (day>0 && day<8)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}
else
{
    Console.WriteLine("Введенная цифра не соответствует дню недели");
}