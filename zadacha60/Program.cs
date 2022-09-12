//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
//двузначных чисел. Напишите программу, которая будет построчно 
//выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[,,] numbers = new int[2, 2, 2];

RandomNumbers(numbers);
WriteMassiv(numbers);

void RandomNumbers(int[,,] massiv)
{
    Random rand = new Random();

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int h = 0; h < massiv.GetLength(2); h++)
            {
                while (massiv[i, j, h] == 0)
                {
                    int number = rand.Next(10, 100);

                    if (IsNumberInArray(massiv, number) == false)
                    {
                        massiv[i, j, h] = number;
                    }
                }

            }
        }
    }
}


bool IsNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }

    return false;
}

void WriteMassiv(int[,,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
            {
                Console.Write(massiv[i, j, k]);
                Console.Write("({0},{1},{2})\t", i, j, k);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}