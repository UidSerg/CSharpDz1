/*
////////////////////////////////////Урок 7. Двумерные массивы
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*

double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    int[] random = { -100, 100 }; // массив для случайного умножения
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (new Random().NextDouble()) * (random[new Random().Next(2)]);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(Math.Round(matr[i, j], 1) + "\t"); // выводим не более 1 знака после запятой
        }
        Console.WriteLine();
    }
}
int m = 3; //не сказано что ввести с клавиатуры просто объявим по условию задачи
int n = 4;
double[,] resultMatrix = GetMatrix(m, n);
PrintMatrix(resultMatrix);
*/
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1(строчка) 7 (столбец) -> такого числа в массиве нет
*/
/*
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

int[,] resultMatrix = GetMatrix(10, 10, 0, 10);

Console.Write("Введите через запятую позицию элемента(x,y): ");
string[] posishinArray = Console.ReadLine().Split(",");
if (posishinArray.Length != 2)
{
    Console.Write("Неверный формат координат");
    return;
}
int posishinRows = Convert.ToInt32(posishinArray[0]);
int posishinCols = Convert.ToInt32(posishinArray[1]);
if(posishinRows > resultMatrix.GetLength(0) || posishinRows < 1 || posishinCols > resultMatrix.GetLength(1) || posishinCols < 1)
{
    Console.Write("указаны неверные координаты элемента");
    return;    
}
int element = resultMatrix[posishinRows - 1, posishinCols - 1];
Console.WriteLine("В массиве: ");
PrintMatrix(resultMatrix);
Console.WriteLine($"элемент с указанной вами позицией ({String.Join(",", posishinArray)}) = {element}");
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
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

int[,] resultMatrix = GetMatrix(4, 4, 0, 9);
PrintMatrix(resultMatrix);
double[] answer = new double[resultMatrix.GetLength(1)];
for (int j = 0; j < resultMatrix.GetLength(1); j++) //перебор столбцов в матрице
{
    int rows = 0;
    double sum = 0;
    while (rows < resultMatrix.GetLength(0))
    {
        sum = sum + resultMatrix[rows, j];
        rows++;
    }
    answer[j] = Math.Round(sum / rows, 2);
}
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", (answer))}");
/* Доп задача: сумма элементов главной диагонали*/
if (resultMatrix.GetLength(0) != resultMatrix.GetLength(1))
{
    Console.WriteLine($"Невозможно выявить главную диагональ!!!");
    return;
}
int sumDiagonali = 0;
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    sumDiagonali = sumDiagonali + resultMatrix[i, i];
}
Console.WriteLine($"Cумма элементов главной диагонали: {sumDiagonali}");