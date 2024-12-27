using Tyuiu.DyakovMS.Sprint6.Task5.V25.Lib;

namespace Tyuiu.DyakovMS.Sprint6.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();
            string filePath = @"C:\\Users\\ananas\\source\\repos\\tyuiu.cources.programming.files-main\\Sprint6Task5\\InPutDataFileTask5V25.txt";

            var res = ds.LoadFromDataFile(filePath);
            int wait = 3;
            Assert.Equals(wait, res);
        }
    }
}