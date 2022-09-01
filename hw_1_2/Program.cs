// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int numberC = int.Parse(Console.ReadLine());

int[] i = {numberA, numberB, numberC};
int MaxValue = i.Max();
Console.WriteLine($"Максимальное число {MaxValue}");
