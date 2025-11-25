using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BatTI.Sprint5.Task7.V9.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V18.txt" });


            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSave);
            }
            string fileContent = File.ReadAllText(path);
            foreach(char c in fileContent)
            {
                if ((char.IsUpper(c) == true) && ((c >= 'A') & (c <= 'Z')))
                {
                    fileContent = fileContent.Replace(c, ' ');
                }
            }
            string modifiedContent = fileContent;
            File.WriteAllText(pathSave, modifiedContent);
            return modifiedContent;
        }
    }
}
