Console.WriteLine("Введите трехзначное число: ");
string num = Console.ReadLine();
int x = int.Parse(num);

if (x>=100 && x<1000)
{
    int a = (x / 10) % 10;

    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Число не соответствует критериям");
}




