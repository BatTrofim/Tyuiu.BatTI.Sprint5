using Tyuiu.BatTI.Sprint5.Task0.V25.Lib;
DataService ds = new DataService();


Console.Title = "Спринт #5 | Выполнил: Бат Т. И. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File                                                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович  | ПИНб-25-1                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 3;
Console.WriteLine("X = " + x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(x);
Console.WriteLine(res);
Console.ReadKey();