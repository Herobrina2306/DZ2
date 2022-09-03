// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Ввечите число");
int a = int.Parse(Console.ReadLine());
int b = a/100;
if(b == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int c = b%10;
    Console.WriteLine($"{a} -> {c}");
}