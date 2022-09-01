// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Все четные числа: ");
for (int i = 0; i <= number; i += 2) {
    
    Console.WriteLine(i);
};
