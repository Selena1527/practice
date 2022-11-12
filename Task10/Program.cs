// Упражнение 3
// Напишите программу, которая выводит на консоль таблицу умножения

int result;
for (int i = 1; i < 11; i++)
{
    for (int j = 1; j < 11; j++)
    {
        result = i * j;
        Console.WriteLine($"{i} * {j} = {result}\t");
    }
    Console.WriteLine();
}