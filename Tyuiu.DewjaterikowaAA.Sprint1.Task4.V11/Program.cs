// See https://aka.ms/new-console-template for more information

using Tyuiu.DewjaterikowaAA.Sprint1.Task4.V11.Lib;

DataService ds = new DataService();


Console.Title = "Спринт #1 | Выполнила: Девятерикова А.А. | ИИПБ - 25 - 1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнила: Девятерикова Анастасия Андреевна | ИИПБ - 25 - 1             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* Формула:                                                                *");
Console.WriteLine("* arctgx / e ^ y                                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x, y;

Console.WriteLine("Введите значение Х:");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение выражения arctgx / e ^ y  = " + ds.Calculate(x, y));
Console.ReadKey();

