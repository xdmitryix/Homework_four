// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindResult(int numOne, int numTwo)
{
    int result = numOne;
    for (int i = 2; i <= numTwo; i++)
    {
        result=result*numOne;
    }
    return result;
}

int numberOne = DataEntry("Введи число A: ");
int numberTwo = DataEntry("Введи число B: ");
int result = FindResult(numberOne, numberTwo);
Console.WriteLine("результат: " + result);