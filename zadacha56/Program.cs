//Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой 
//элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] numbers = new int[4, 4];
RandomNumbers(numbers);
WriteMassiv(numbers);
Console.WriteLine();
Console.WriteLine(MinSumRow(numbers) + " строка");

int MinSumRow(int[,] massiv)
{
    int[] sum = new int[massiv.GetLength(0)];
    int min = SumLine(massiv, 0);
    int iRow = 1;
    for (int i = 0; i < massiv.GetLength(0); i++)
        sum[i] = SumLine(massiv, i);

    for (int i = 0; i < massiv.GetLength(0); i++)
        if (min > sum[i])
        {
            min = sum[i];
            iRow = i + 1;
        }

    return iRow;
}

int SumLine(int[,] massiv, int Row)
{
    int sum = 0;
    for (int i = 0; i < massiv.GetLength(1); i++)
        sum = sum + massiv[Row, i];

    return sum;
}

void RandomNumbers(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(0, 10);
        }
    }
}

void WriteMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write(massiv[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
