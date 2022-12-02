// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();


int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindSum(int num)
{
    int sum = 0;
    for (int i = num; num > 0; i = num / 10)
    {
        sum = sum + num % 10;
    }
    return sum;
}


int number = DataEntry("Введи число: ");
int sum = FindSum(number);
Console.WriteLine("сумма цифр в числе: " + sum);
