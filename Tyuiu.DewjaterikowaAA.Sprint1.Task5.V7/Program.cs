// See https://aka.ms/new-console-template for more information

using Tyuiu.DewjaterikowaAA.Sprint1.Task5.V7.Lib;

DataService ds = new DataService();


Console.Title = "Спринт #1 | Выполнила: Девятерикова А.А. | ИИПБ - 25 - 1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнила: Девятерикова Анастасия Андреевна | ИИПБ - 25 - 1             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до     *");
Console.WriteLine("* того момента (в первой половине дня), когда часовая стрелка повернулась *");
Console.WriteLine("* на f градусов (0<f<360, f – вещественное число).                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double f;

Console.WriteLine("Введите значение F:");
f = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("Время на часах  = " + ds.AngleToHoursMinutes(f));
Console.ReadKey();
