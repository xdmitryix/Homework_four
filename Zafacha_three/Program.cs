// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();
int[] numbers = new int[8];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 99);
    if (i == 0)
    {
        Console.Write("[" + numbers[i] + ",");
    }
    else
        if (i == 7)
    {
        Console.Write(numbers[i] + "]");
    }
    else
    {
        Console.Write(numbers[i] + ",");
    }
}


//  Ниже добавил вариант с функцией. Но он у меня не работает. Что-то сделал не так, а что именно-понять не могу. Напишите в комментарии как
//  мне правильно сделать функцию для моего решения. Спасибо !. 



// Console.Clear();

// void result(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(0, 99);
//         if (i == 0)
//         {
//             Console.Write("[" + numbers[i] + ",");
//         }
//         else
//             if (i == 7)
//         {
//             Console.Write(numbers[i] + "]");
//         }
//         else
//         {
//             Console.Write(numbers[i] + ",");
//         }
//     }
// }

// int arr = result(new int[8]);
// Console.WriteLine(arr);