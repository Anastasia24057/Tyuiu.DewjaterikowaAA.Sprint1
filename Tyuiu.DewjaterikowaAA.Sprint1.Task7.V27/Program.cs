// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikowaAA.Sprint1.Task7.V27.Lib;

DataService ds = new DataService();


Console.Title = "Спринт #1 | Выполнила: Девятерикова А.А. | ИИПБ - 25 - 1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #27                                                             *");
Console.WriteLine("* Выполнила: Девятерикова Анастасия Андреевна | ИИПБ - 25 - 1             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет выражение по исходным данным      *");
Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ФОРМУЛА:                                                                *");
Console.WriteLine("*             2        2                                                  *");
Console.WriteLine("*       cos X  + sin Y      x*y - 12                                      *");
Console.WriteLine("*  z = ----------------- - ------------                                   *");
Console.WriteLine("*          sin Y + 1        15 + cos X                                    *");
Console.WriteLine("*                                                                         *");




Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x,y;

Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("z = " + ds.Calculate(x, y));
Console.ReadKey();