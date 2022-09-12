//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] numbers = new int[3, 4];
RandomNumbers(numbers);
WriteMassiv(numbers);
Console.WriteLine();
SortRowMassiv(numbers);
WriteMassiv(numbers);

void SortRowMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(1) - 1; k++)
                if (massiv[i, k] < massiv[i, k + 1])
                {
                    int m = massiv[i, k + 1];
                    massiv[i, k + 1] = massiv[i, k];
                    massiv[i, k] = m;
                }
        }
    }
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
