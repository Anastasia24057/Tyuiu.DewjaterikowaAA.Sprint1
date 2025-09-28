// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikowaAA.Sprint1.Task2.V20.Lib;

DataService ds = new DataService();


Console.Title = "Спринт #1 | Выполнила: Девятерикова А.А. | ИИПБ - 25 - 1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Арифметические операторы в С##                                    *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнила: Девятерикова Анастасия Андреевна | ИИПБ - 25 - 1             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* Формулировка задания: Заданы два числа. Вычислить сумму их квадратов.   *");
Console.WriteLine("* Что пользователь вводит? Первое число (целое), Второе число (целое)     *");
Console.WriteLine("* Что программа печатает на экране? Сумма квадратов (целое число)         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x;
int y;

Console.WriteLine("Введите значение Х:");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма квадратов чисел Х и Y = " + ds.CalculateSquaresSumm(x, y));
Console.ReadLine();

