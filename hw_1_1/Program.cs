// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB) {
    Console.WriteLine($"Число A: {numberA} больше числа B: {numberB}");
}
else{
    Console.WriteLine($"Число B: {numberB} больше числа A: {numberA}");
};