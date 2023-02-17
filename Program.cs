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
