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
int[,] matrix1 = GetMatrix(2, 4, 0, 5); //зададим матрицы
int[,] matrix2 = GetMatrix(4, 2, 0, 5);
PrintMatrix(matrix1);
Console.WriteLine("*");
PrintMatrix(matrix2);
//перемножить можно только матрицы у которых число столбцов первой матрицы равно числу строк второй матрицы
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Невозможно");
    return;
}
int [,] resulMatrix = GetMatrix(matrix1.GetLength(0), matrix2.GetLength(1), 0, 0);
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix2.GetLength(0); k++)
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
/*
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
*/
/*
ДОПОЛНИТЕЛЬНАЯ ЗАДАЧКА
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int [,] newMatrix = GetMatrix(6,6,0,0); //генерируем матрицу нолей любого размера 
int rows = newMatrix.GetLength(0);
int cols = newMatrix.GetLength(1);
int count = 1;

for (int k = 0;k < rows/2; k++)
{
int i = 0;
while ( i+k < rows-k)
{
    newMatrix[0+k,i+k] = count;
    i++;
    count++;
}
int j = 1;
while ( j+k < cols-k)
{
    newMatrix[j+k,cols-1-k] = count;
    j++;
    count++;
}

while (i > 1)
{
    newMatrix[rows-1-k,i-2+k] = count;
    i--;
    count++;
}

while ( j >2)
{
    newMatrix[j-2+k,0+k] = count;
    j--;
    count++;
}
}
PrintMatrix(newMatrix);

/*
////////////////////////////////////////Урок 9. Рекурсия////////////////////////////////
Задача 64: Задайте значение N.
Напишите программу,которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
Console.Write("Введите число N: ");
bool check = int.TryParse(Console.ReadLine(), out int valueN);
if (check == false)
{
Console.WriteLine($"введен не число");
return;
}
/// <summary>
/// Печатаем все натуральные числа в промежутке от N до 1.
/// </summary>
/// <param name="n">Число задающее промежуток</param>
/// <returns></returns>
string GetValue(int n)
{
    if (n == 1) return n.ToString();
    return (n + "," + GetValue(n - 1));
}
Console.WriteLine(GetValue(valueN));
*/
/*
Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
Console.Write("Введите число M: ");
int M = Math.Abs(Convert.ToInt32(Console.ReadLine())); //число натуральное убираем минус если вдруг введут
Console.Write("Введите число N: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (M>=N)
{
    Console.WriteLine("НЕверно задан промежуток натуральных чисел от M до N");
    return;
}
/// <summary>
/// Считаем сумму натуральных чисел от M до N
/// </summary>
/// <param name="start"> M = start</param>
/// <param name="end"> N = end</param>
/// <returns></returns>
int PrintSum(int start, int end)
{
    // Базовый
    if (start == end) return end;
    // Рекурсивный
    return (start + PrintSum(start+1, end));
}

Console.WriteLine(PrintSum(M, N));
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
Console.Write("Введите число M: ");
int M = Math.Abs(Convert.ToInt32(Console.ReadLine())); //число натуральное убираем минус если вдруг введут
Console.Write("Введите число N: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int GetAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) return GetAckerman(m - 1, 1);
    else return GetAckerman(m - 1, GetAckerman(m, n - 1));
}
Console.WriteLine(GetAckerman(M, N));
*/