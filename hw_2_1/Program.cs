// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Выхода из программы команда Exit.\nВведите трехзначное число:");
    while(true)
    {
        string three_num = Console.ReadLine();
        if(!three_num.Equals("exit"))
            Console.WriteLine("{0}->{1}",three_num, three_num[1]);
        else
            break;
    }
