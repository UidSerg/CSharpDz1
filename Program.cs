
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write(matr[i, m] + "\t");
        }
        Console.WriteLine();
    }
}

//решение
/*
ДОПОЛНИТЕЛЬНАЯ ЗАДАЧКА
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] newMatrix = GetMatrix(5, 5, 0, 0); //генерируем матрицу нолей любого размера 
int rows = newMatrix.GetLength(0);
int cols = newMatrix.GetLength(1);
if (rows != cols || rows % 2 != 0)
{
    Console.WriteLine("к сожалению не получится");
    return;
}

int count = 1;

for (int k = 0; k < rows / 2; k++)
{
    int i = 0;
    while (i + k < rows - k)
    {
        newMatrix[0 + k, i + k] = count;
        i++;
        count++;
    }
    int j = 1;
    while (j + k < cols - k)
    {
        newMatrix[j + k, cols - 1 - k] = count;
        j++;
        count++;
    }

    while (i > 1)
    {
        newMatrix[rows - 1 - k, i - 2 + k] = count;
        i--;
        count++;
    }

    while (j > 2)
    {
        newMatrix[j - 2 + k, 0 + k] = count;
        j--;
        count++;
    }
}
PrintMatrix(newMatrix);