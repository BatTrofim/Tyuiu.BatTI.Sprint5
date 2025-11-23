using System.IO;
using Tyuiu.BatTI.Sprint5.Task3.V3.Lib;


namespace Tyuiu.BatTI.Sprint5.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.BatTI.Sprint5\Tyuiu.BatTI.Sprint5.Task3.V3\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
