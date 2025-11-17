using Tyuiu.BatTI.Sprint5.Task0.V25.Lib;
using System.IO;
namespace Tyuiu.BatTI.Sprint5.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.BatTI.Sprint5\Tyuiu.BatTI.Sprint5.Task0.V25\bin\Debug\OutPutFileTask0.txt";
            FileInfo fl = new FileInfo(path);
            bool res = fl.Exists;
            Assert.AreEqual(true, res);
        }
    }
}
