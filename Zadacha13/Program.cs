// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if(a < 100)
{

        Console.WriteLine($"{a} -> Третьей цифры нет");
}
else
{
    int b = a;
    while(b > 1000)
    {
        b = b/10;
    }
    int c = b%10;
    Console.WriteLine($"{a} -> {c}");
}