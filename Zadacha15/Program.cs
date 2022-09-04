// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

string[] array = {"от одного до семи", "нет", "нет", "нет", "нет", "нет", "да", "да"};
Console.WriteLine("Введите число от одного до семи");
int i = int.Parse(Console.ReadLine());
if(i < 1 || i > array.Length-1)
{
    Console. WriteLine("От одного до семи. Попробуйте ещё раз.");
}
else
{
    Console.WriteLine($"{i} -> {array[i]}");
} 


Console.WriteLine("Введите число от одного до семи");
int a = int.Parse(Console.ReadLine());
if(a < 1 || a > 7)
{
    Console. WriteLine("От одного до семи.");
}
else
{
    if(a == 6 || a ==7)
    {
        Console.WriteLine($"{a} -> да");
    }
    else
    {
        Console.WriteLine($"{a} -> нет");
    }
}