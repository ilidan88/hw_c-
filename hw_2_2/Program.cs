//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число: ");

int Number = Convert.ToInt32(Console.ReadLine());

string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2){
  Console.WriteLine($"третья цифра -> {NumberText[2]}");
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
