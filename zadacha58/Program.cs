//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

RandomNumbers(matrix1);
RandomNumbers(matrix2);

Console.WriteLine("1 матрица");
WriteMassiv(matrix1);
Console.WriteLine();
Console.WriteLine("2 матрица");
WriteMassiv(matrix2);
Console.WriteLine();
Console.WriteLine("Результат");
WriteMassiv(ResultMatrix(matrix1, matrix2));

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

///
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


int[,] ResultMatrix(int[,] massiv1, int[,] massiv2)
{
    int[,] result = new int[massiv1.GetLength(0), massiv2.GetLength(1)];
    for (int i = 0; i < massiv1.GetLength(0); i++)
    {
        for (int j = 0; j < massiv2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < massiv1.GetLength(1); k++)
            {
                sum += massiv1[i, k] * massiv2[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}