using Tyuiu.BatTI.Sprint5.Task2.V8.Lib;


namespace Tyuiu.BatTI.Sprint5.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Lenovo\source\repos\Tyuiu.BatTI.Sprint5\Tyuiu.BatTI.Sprint5.Task2.V8\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}
