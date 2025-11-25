using System.IO;
using Tyuiu.BatTI.Sprint5.Task7.V9.Lib;
DataService ds = new DataService();


Console.Title = "Спринт #5 | Выполнил: Бат Т. И. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Итоговое решение к проекту                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович  | ПИНб-25-1                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask7V9.txt";

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.LoadDataAndSave(path);
Console.WriteLine(res);
Console.ReadKey();