using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BatTI.Sprint5.Task3.V3.Lib
{
    public class DataService : ISprint5Task3V3
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            double y = (x * (x * Math.Sqrt(x + 3)));
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
