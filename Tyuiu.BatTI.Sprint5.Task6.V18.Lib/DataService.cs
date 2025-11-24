using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.BatTI.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string s = "0123456789";

                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length - 2; i++)
                    {
                        string str0 = line[i].ToString();
                        string str = line[i + 1].ToString();
                        string str1 = line[i + 2].ToString();

                        if (i == 0)
                        {
                            if ((s.Contains(str0)) & !(s.Contains(str)))
                            {
                                count++;
                            }
                        }
                        if (!(s.Contains(str0)) & s.Contains(str) & !(s.Contains(str1)))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
