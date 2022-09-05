// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите порядковый номер дня недели: ");

int dayWeek = Convert.ToInt32(Console.ReadLine());

void ChecDayWeek (int dayWeek) {
    if (dayWeek == 6 || dayWeek == 7) {
    Console.WriteLine("(этот день выходной) -> да");
    }
    else if (dayWeek < 1 || dayWeek > 7) {
        Console.WriteLine("такого дня недели не существует ");
    }
    else Console.WriteLine("(этот день выходной) -> нет");
}

ChecDayWeek(dayWeek);