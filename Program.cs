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


