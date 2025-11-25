using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BatTI.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V9.txt");
            string text = File.ReadAllText(path);
            foreach (char c in text)
            {
                if (char.IsUpper(c) == true)
                {
                    text = text.Replace(c, ' ');   
                }                
            }
            File.AppendAllText(text, path);
            return text;
        }
    }
}
