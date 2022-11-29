//Урок 1. Знакомство с языком программирования С#
//Практическое задание
/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
/*
Console.WriteLine("Введи певое число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine());

int max = number;
int min = number;

if (number > max) max = number;
if (number2 > max) max = number2;
if (number < min) min = number;
if (number2 < min) min = number2;
{
   Console.WriteLine($"Это число больше {max}"); 
   Console.WriteLine($"Это число меньше {min}"); 
}
*/
/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22  */

Console.WriteLine("Введи певое число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введи второе число: ");
int number3 = int.Parse(Console.ReadLine());

int max = number;

if (number > max) max = number;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

{
   Console.WriteLine($"Это самое большое число {max}"); 
}


/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет  */

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8  */








//Seminar_1
/*/ Напишите программу, которая на вход принимает число и принимает его квадрат (число умноженое на само себя)

Console.WriteLine("Введи число: ");
int number = int.Parse(Console.ReadLine());

// Возведение в квадрат математическим методом

int sqr = number * number;
Console.WriteLine($"квадрат числа {number} равен = {sqr}");

// Метод с использованием библиотеки

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Вложенная библиотека: квадрат числа {number} равен = {sqr1}");*/

/*/ Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введи певое число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine());

// Делаем ветвление для проверки условия

if (Math.Pow(number2, 2) == number) {
   Console.WriteLine("Первое число является квадратом второго"); 
}
else{
    Console.WriteLine("Первое число не является квадратом второго");
}
*/

/*/ Задача 2. Напишите программу, которая будет выдавать день недели по заданному номеру

Console.WriteLine("Введи день недели: ");
int day = int.Parse(Console.ReadLine());

if (day == 1)
{
   Console.WriteLine($"День {day} это Понедельник"); 
}
if (day == 2)
{
   Console.WriteLine($"День {day} это Вторник"); 
}
if (day == 3)
{
   Console.WriteLine($"День {day} это Среда"); 
}
if (day == 4)
{
   Console.WriteLine($"День {day} это Четверг"); 
}
if (day == 5)
{
   Console.WriteLine($"День {day} это Пятница"); 
}
if (day == 6)
{
   Console.WriteLine($"День {day} это Суббота"); 
}
if (day == 7)
{
   Console.WriteLine($"День {day} это Воскресенье"); 
}
*/

// Задача 3. Напишите программу, которая на вход принимает одно число N, а на выходе показывает все целые числа от -N до N

/* Console.Write("Введи число N: ");
int n = int.Parse(Console.ReadLine());
int a = -n;
while (a <= n)
{
    //Console.Write(a+" ");
    Console.Write($"{a} ");
    a++;
}
*/

/*/ Задача 4. Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа

Console.Write("Введи число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("последняя цифра числа " + n + " = " + n % 1000);
Console.WriteLine($"последняя цифра числа {n} = {n % 10}");
*/