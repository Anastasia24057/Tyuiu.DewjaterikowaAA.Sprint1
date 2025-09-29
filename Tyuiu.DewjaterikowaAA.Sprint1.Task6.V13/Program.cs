// See https://aka.ms/new-console-template for more information

using Tyuiu.DewjaterikowaAA.Sprint1.Task6.V13.Lib;

DataService ds = new DataService();


Console.Title = "Спринт #1 | Выполнила: Девятерикова А.А. | ИИПБ - 25 - 1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнила: Девятерикова Анастасия Андреевна | ИИПБ - 25 - 1             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что буквы     *");
Console.WriteLine("* строки упорядочены по алфавиту.                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("Введите строку:");
string str = Console.ReadLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.CheckWordsAlphabet(str));
Console.ReadKey();