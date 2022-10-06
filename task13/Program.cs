// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
string str = Console.ReadLine();
char [] array = str.ToCharArray();

int l = array.Length;

if (l>2)
{
    Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}