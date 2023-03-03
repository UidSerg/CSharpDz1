// 1-й семинар
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
/*

Console.Write("Введите  первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
//if (a == b)  Console.WriteLine("Вы ввели одинаковые числа!"); // можно проверить на равенство
if(a>b) 
{
    Console.WriteLine("Наибольшее значение " + a);
}
else
{
    Console.WriteLine("Наибольшее значение " + b);
}

*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*
Console.Write("Введите  первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Наибольшее значение " + a);
    }
    else
    {
        Console.WriteLine("Наибольшее значение " + c);
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine("Наибольшее значение " + b);
    }
    else
    {
       Console.WriteLine("Наибольшее значение " + c); 
    }
}

*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

/*
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) Console.WriteLine("Число " + a + " - четное");
else Console.WriteLine("Число " + a + " - нечетное");

*/
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
/*
int count = 2; //первое четное число после 1
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("четные числа:");
while (count <= N)
{
    Console.Write(count + ","); 
    count = count + 2;
}

*/
// 2й семинар
//Напишите программу, которая принимает на вход трёхзначное число и на выходе
//показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

/*

Console.Write("Введите трехзначное число: ");
bool check = int.TryParse(Console.ReadLine(), out int value);
if (check == false)
    {
        Console.WriteLine($"Вы ввели что-то не хорошее, можно только цифры 0-9 И минус");
        return;
    }

int value = Math.Abs(value);  // модуль числа при отрицательных режет минус
if (value > 999 || value < 99)
{
    Console.Write("Введено не верное число!!!");
}
else
{
   result = value % 100;
   result = result /10;
   Console.Write($"Второе число в введенном трехзначном числе {value} - {result}");
}
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//семизначного числа или сообщает, что третьей цифры нет.
//78 -> третьей цифры нет
//3267900 -> 6
//ДОП: цифра третья может быть как с левой стороны, так и с правой

/*
int result = 0;
int countIndex = 1;
Console.Write("Введите число: ");
bool check = int.TryParse(Console.ReadLine(), out int value);
if (check == false)
    {
        Console.WriteLine($"Вы ввели что-то не хорошее, можно только цифры 0-9 И минус");
        return;
    }

value = Math.Abs(value);
int RightValue = value; // для справа
int count = value;

while (count >= 10)
{
    count = count / 10;
    countIndex++;
}
if (countIndex > 7)
{
    Console.Write("Введено не верное число!!!");
}
else
{
    Console.WriteLine($"в введенном числе: {value} - {countIndex} знаков");

    if (countIndex < 3)
    {
        Console.Write("Мало разрядов числа 3го нет!!!");
        return;
    }
    else
    {
        while (countIndex > 3)
        {
            value = value / 10;
            countIndex--;
        }

    }

    result = value % 10;
    RightValue = RightValue % 1000;
    RightValue = RightValue / 100;

    Console.WriteLine($"Третья слева {result}, третья справа {RightValue}");

}

*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
/*
Console.Write("Введите день недели: ");
    bool check = int.TryParse(Console.ReadLine(), out int value);
    if (check == false)
    {
        Console.WriteLine($"Вы ввели что-то не хорошее, можно только цифры 1-7");
        return;
    }
else
{
    if (value > 7 || value < 1)
    {
        Console.WriteLine($"В неделе 7 дней а не {value} дней");
        return;
    }
    if (value == 6 || value == 7) Console.WriteLine("Ура выходной!!!!");
    else Console.WriteLine("Идем работать");
}
*/
//Домашнее задание 3й семинар
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
bool krai1 = false;
bool krai2 = false;
Console.Write("Введите пятизначное число: ");

if (value > 9999 && value < 100000)
{
    int copyValue = value; 
    if (value / 10000 == value % 10)
    {
        krai1 = true;
        value = value % 10000; //12321>2321
        value = value / 10; //232
        if (value / 100 == value % 10)
        {
            krai2 = true;
        }
        else
        {
            krai2 = false;
        }
    }
    else
    {
        krai1 = false;
    }
    if (krai1 == krai2 && krai2 == true)
    {
        Console.WriteLine($"число {copyValue} палиндром");
    }
    else
    {
        Console.WriteLine($"число {copyValue} не является палиндромом");
    }
}
else
{
    Console.WriteLine($"Вы ввели не 5-ти значное число ");
}
*/
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
// Точка A(x1;y1;z1)
Console.Write("Введите координату точки A по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки  A по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки  A по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
//Точка B(x2;y2;z2)
Console.Write("Введите координату точки B по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
Console.WriteLine(Math.Round(result,2));
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
Console.Write("Введите N: ");
bool check = int.TryParse(Console.ReadLine(), out int N);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не хорошее, можно только цифры 1-9");
    return;
}
N = Convert.ToInt32(N);
for (int i = 1; i <= N; i++)
{
Console.Write(Math.Pow(i,3)+ "\n");    
}
*/

/*Доп. задание №1:
Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада.
 На вход будет подаваться число (сумма вклада). 
 При значении меньше 100, будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %, 
 если больше — 10 %.
 Отработав, программа должна вывести общую сумму с начисленными процентами.
 */
/*
Console.Write("Введите сумму вклада: ");
bool check = double.TryParse(Console.ReadLine(), out double vklad);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 1-9");
    return;
}
vklad = Convert.ToInt32(vklad);
if (vklad < 0)
{
    Console.WriteLine($"Вклад не может быть отрицательным!");
    return;
}
//< 100ye - 5% || 7%|| 10% - > 200ye
double result =0;
if (vklad <= 200 &&  vklad >= 100)
{
    result = Math.Round((vklad+vklad*0.07),2);
    Console.WriteLine($"Ваш Вклад {vklad} увеличится на 7% и составит:{result} y.e");
}
else if (vklad < 100)
{
    result = Math.Round((vklad+vklad*0.05), 2);
    Console.WriteLine($"Ваш Вклад {vklad} увеличится на 5% и составит:{result} y.e ");
}
else if (vklad > 200)
{
    result = Math.Round((vklad+vklad*0.1), 2);
    Console.WriteLine($"Ваш Вклад {vklad} увеличится на 10% и составит: {result} y.e ");
}

*/
/*
Доп. задание №2:
Назовем число интересным,
если в нем разность максимальной и минимальной цифры равняется средней по РАСПОЛОЖЕНИЮ цифре. 
Напишите программу, которая определяет интересное число или нет.
Если число интересное, следует вывести – «Число интересное» иначе «Число неинтересное».
-> 954 - число интересное, средняя цифра - 5, разница: 9 - 4 = 5.
Средняя цифра - цифра(962-6, 23456 - средняя 4)
*/
/*
Console.Write("Введите сумму число: ");
bool check = int.TryParse(Console.ReadLine(), out int value);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 1-9");
    return;
}
value = Math.Abs(Convert.ToInt32(value)); // уберем минус
int i = 1;
int valueCount = value;
while (valueCount / 10 > 0)
{
    valueCount = valueCount / 10;
    i++;
}

Console.WriteLine($" в числе {i}  цифр");
if (i % 2 == 0)
{
    Console.WriteLine($" в число {value} четное число разрядов в нем нет средней будем считать его НЕИНТЕРЕСНЫМ");
    return;
}

int[] array = new int[i]; // сделаем массив i длины

int valueArray = value;
for (int j = 0; j < i; j++)
{
    array[j] = valueArray % 10;
    valueArray = valueArray / 10;
}
// 12345-> {5,4,3,1,0} наоброт в принципе же без разницы

int max = int.MinValue; // вычисляем макс
for (int q = 0; q < array.Length; q++)
{
    if (array[q] > max)
    {
        max = array[q];
    }
}

int min = int.MaxValue; // вычисляем мин
for (int q = 0; q < array.Length; q++)
{
    if (array[q] < min)
    {
        min = array[q];
    }
}

int razn = max - min;
int arrayi = i / 2; // array.Lenght/2

if (razn == array[arrayi])
{
    Console.WriteLine($" в число {value} интересное");
}
else
{
    Console.WriteLine($" в число {value} НЕ интересное");
}
*/

/*//////////////////////////4 Семинар////////////////////////////////////
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*

Console.Write("Введите число А: ");
bool check = int.TryParse(Console.ReadLine(), out int valueA);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 1-9");
    return;
}
Console.Write("Введите число В: ");
bool check2 = int.TryParse(Console.ReadLine(), out int valueB);
if (check2 == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 1-9");
    return;
}

int GetMnog(int A)
{
    int mnog = 1;
    for (int i = 1; i <= valueB; i++)
    {
        mnog *= valueA;
    }
    return mnog;
}

Console.WriteLine($"Число {valueA} в степени {valueB} = {GetMnog(valueB)}"); 
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Console.Write("Введите число А: ");
bool check = int.TryParse(Console.ReadLine(), out int value);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 1-9");
    return;
}

int GetSumElem(int element)
{
    int sum = 0;
    while (element > 0)
    {
        sum = sum + element % 10;
        element = element / 10; 
    }
    return sum;

}
Console.WriteLine($"сумма элементов {value}  = {GetSumElem(value)}"); 
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*
int[] GetArray(int size)
{
    int[] array = new int[size];
    size = array.Length;
    for (int i = 0; i < size; i++)
    {
    
     array[i] = new Random().Next(0,100); 
        
    }
    return array;
}

int[] resultArray = GetArray(8);

Console.WriteLine($"Массив: [{String.Join(";",resultArray)}]");
*/
/*
///////////////////////Семинар 5 Функции и одномерные массивы///////////////////////////
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
Console.Write("Введите длину массива: ");
bool check = int.TryParse(Console.ReadLine(), out int size);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 0-9");
    return;
}
if (size < 2)
{
    Console.WriteLine($"Слишком короткий массив, Нужно хотябы 2 элемента ");
    return;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    size = array.Length;
    for (int i = 0; i < size; i++)
    {

        array[i] = new Random().Next(100, 1000);

    }
    return array;
}
int[] resultArray = GetArray(size);
int sum = 0;
for (int i = 0; i < size; i++)
{
    if (resultArray[i] % 2 == 0) sum++;
}

Console.WriteLine($"в массиве: [{String.Join(";", resultArray)}] -{sum} четных чисел");
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
Console.Write("Введите длину массива: ");
bool check = int.TryParse(Console.ReadLine(), out int size);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 0-9");
    return;
}
if (size < 2)
{
    Console.WriteLine($"Слишком короткий массив, Нужно хотябы 2 элемента ");
    return;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    size = array.Length;
    for (int i = 0; i < size; i++)
    {

        array[i] = new Random().Next(-100, 100);

    }
    return array;
}
int[] resultArray = GetArray(size);
int sum = 0;
for (int i = 1; i < size; i = i+2) //пройдем понечетным позициям циклом
{
   sum += resultArray[i];
}

Console.WriteLine($"в массиве: [{String.Join(";", resultArray)}] сумма элементов на нечетных позициях = {sum}");
*/
/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
Используйте NextDouble().
*/
/*
Console.Write("Введите длину массива: ");
bool check = int.TryParse(Console.ReadLine(), out int size);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 0-9");
    return;
}
if (size < 2)
{
    Console.WriteLine($"Слишком короткий массив, Нужно хотябы 2 элемента ");
    return;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(100*(new Random().NextDouble())); // Функцию использовали и сразу обратно в int)
    }
    return array;
}
int[] resultArray = GetArray(size);

int max = int.MinValue; // вычисляем макс
for (int i = 0; i < size; i++)
{
    if (resultArray[i] > max)
    {
        max = resultArray[i];
    }
}

int min = int.MaxValue; // вычисляем мин
for (int i = 0; i < size; i++)
{
    if (resultArray[i] < min)
    {
        min = resultArray[i];
    }
}

int razn = max - min;

Console.WriteLine($"массиве: [{String.Join(";",(resultArray))}] разница между максимальным и минимальным элементом массива = {razn}");
*/
/*
Доп. задачка:
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/
/*
Console.Write("Введите длину массива: ");
bool check = int.TryParse(Console.ReadLine(), out int size);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 0-9");
    return;
}
if (size < 2)
{
    Console.WriteLine($"Слишком короткий массив, Нужно хотябы 2 элемента ");
    return;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10);
    }
    return array;
}
int[] resultArray = GetArray(size);

if (size % 2 == 0) //четный массив
{
    int[] newArray = new int[size / 2];
    for (int i = 0; i < size / 2; i++)
    {
        newArray[i] = resultArray[i] * resultArray[(size - 1) - i]; //длина массва от 1 элементы от 0
    }

    Console.WriteLine($"массив1 : [{String.Join(";", (resultArray))}] новый массив [{String.Join(";", (newArray))}]");
}
else
{
    int[] newArray = new int[(size / 2) + 1]; //нечетный массив
    for (int i = 0; i < size / 2; i++)
    {
        newArray[i] = resultArray[i] * resultArray[(size - 1) - i];
    }
    newArray[size / 2] = resultArray[size / 2];
    Console.WriteLine($"массив1 : [{String.Join(";", (resultArray))}] новый массив [{String.Join(";", (newArray))}]");
}
*/
/*Семинар 6  домашнее задание
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
Console.Write("Введите сколько чисел хотите ввести для проверки: ");
bool check = int.TryParse(Console.ReadLine(), out int size);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 0-9");
    return;
}
int[] arrayValue = new int[size];
int sum = 0; // колличество чисел больше 0
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1} число: ");
    bool info = int.TryParse(Console.ReadLine(), out int value);
    if (info == false)
    {
        Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 0-9");
    }
    else
    {
        arrayValue[i] = value;
        if (value > 0) sum++;
    }
}

Console.WriteLine($"Среди введенных вами чисел: {String.Join(",", (arrayValue))}, положительных:{sum}");
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*прямые пересекаются когда 
k1 * x + b1 = k2 * x + b2
k1*x-k2*x = b2-b1
x= (b2-b1)/(k1-k2)
*/
Console.Write("введите угловой коэффициент для первой прямой: ");
bool check = int.TryParse(Console.ReadLine(), out int k1);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 0-9");
    return;
}
Console.Write("введите угловой коэффициент для второй прямой: ");
check = int.TryParse(Console.ReadLine(), out int k2);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 0-9");
    return;
}
Console.Write("введите смещение первой прямой: ");
check = int.TryParse(Console.ReadLine(), out int b1);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 0-9");
    return;
}
Console.Write("введите смещение второй прямой: ");
check = int.TryParse(Console.ReadLine(), out int b2);
if (check == false)
{
    Console.WriteLine($"Вы ввели что-то не понятное, можно только цифры 0-9");
    return;
}

double x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1;
Console.WriteLine($" прямая y = {k1} * x + {b1} пересекается с  прямой y = {k2} * x + {b2} в точке с координатами ({x},{y})");


/*
Задача 42 (необязательно): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/