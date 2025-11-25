using System.IO;
using Tyuiu.BatTI.Sprint5.Task7.V9.Lib;

namespace Tyuiu.BatTI.Sprint5.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.BatTI.Sprint5\Tyuiu.BatTI.Sprint5.Task7.V9\bin\Debug\OutPutDataFileTask7V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        public void TestMethod2()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V9.txt";
            var res = ds.LoadDataAndSave(path);
            string wait = "ello, ир!то s y irst rogram.";
            Assert.AreEqual(wait, res);
        }
    }
}
