using Tyuiu.BatTI.Sprint5.Task2.V8.Lib;
DataService ds = new DataService();


Console.Title = "Спринт #5 | Выполнил: Бат Т. И. | ПИНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File                                                        *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович  | ПИНб-25-1                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] matrix = { { -9, 4, -6 }, { 3, 9, 9 }, { -6, 7, 4 } };
for (int i = 0; i < 3; i++)
{
    for (int j = 0, count = 0; j < 3; j++, count++)
    {
        if (count != 2)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        else
        {
            Console.Write(matrix[i, j] + "\n");
        }
    }
}
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string path = ds.SaveToFileTextData(matrix);

Console.WriteLine("***************************************************************************");
Console.WriteLine(File.ReadAllText(path));
Console.WriteLine("***************************************************************************");
Console.ReadKey();