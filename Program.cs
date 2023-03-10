/* ////////////////////////////////////8 семинар Двумерные массивы/////////////////////////////
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/// <summary>
/// Метод задает двумерный массив заполненый числами от minValue до maxValue
/// </summary>
/// <param name="rows">колличество строк</param>
/// <param name="cols">колличество строк</param>
/// <param name="minValue">минимальный элемент массива</param>
/// <param name="maxValue">максимальный элемент массива</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
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
/// <summary>
/// метод печает двумерный массив, который передали на вход
/// </summary>
/// <param name="matr">Двумерный массив</param>
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

/*
//решение
int[,] resultMatrix = GetMatrix(4, 4, 0, 9);
PrintMatrix(resultMatrix);

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    int temp = 0;
    for (int j = 0; j < resultMatrix.GetLength(1) - 1; j++) 
    {
        for (int k = j + 1; k < resultMatrix.GetLength(1); k++) //циклично сравнить 
        {
            if (resultMatrix[i, j] < resultMatrix[i, k])
            {
                temp = resultMatrix[i, j];
                resultMatrix[i, j] = resultMatrix[i, k];
                resultMatrix[i, k] = temp;
            }
        }

    }

}
Console.WriteLine("Сортированный массив:");
PrintMatrix(resultMatrix);
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка
*/
/*
int[,] resultMatrix = GetMatrix(4, 5, 0, 9);
if (resultMatrix.GetLength(0) == resultMatrix.GetLength(1))
{
    Console.WriteLine($"Вы задали квадратный массив!");
    return;
}
PrintMatrix(resultMatrix);
int minNumberStrig = 0;
int minStrig = int.MaxValue;
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    int sumString = 0;
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        sumString += resultMatrix[i, j];
    }
    //Console.WriteLine($"{sumString} строка {i + 1}");
    if (sumString < minStrig)
    {
        minStrig = sumString;
        minNumberStrig = i;
    }

}
Console.WriteLine($"Сторока с наименьшей суммой элементов: {minNumberStrig + 1}!");
*/
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] matrix1 = GetMatrix(2, 2, 0, 5);
int[,] matrix2 = GetMatrix(2, 2, 0, 5);
PrintMatrix(matrix1);
Console.WriteLine("*");
PrintMatrix(matrix2);
//перемножить можно только матрицы у которых число столбцов первой матрицы равно числу строк второй матрицы
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Невозможно");
    return;
}
//по заданию матрицы обе матрицы 2х2 результатирующая матрица тоже будет 2х2
int [,] resulMatrix = GetMatrix(2, 2, 0, 0);
for (int i = 0; i < resulMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resulMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < 2; k++)
        {
            resulMatrix[i,j] += matrix1[i,k]*matrix2[k,j]; //сумма (строку матрицы 1 * на столбец матрицы 2)
        }
        
    }
}
Console.WriteLine("Результат");
PrintMatrix(resulMatrix);
*/
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [,,] threeDMass=new int[2,2,2];
for (int i = 0; i < threeDMass.GetLength(0); i++)
{
    for (int j = 0; j < threeDMass.GetLength(1); j++)
    {
        for (int k = 0; k < threeDMass.GetLength(2); k++)
        {
            threeDMass[i,j,k] = new Random().Next(10,100);
            Console.Write($"{ threeDMass[i,j,k]} {(i,j,k)} "); 
        }
        Console.WriteLine();
    } 
}
