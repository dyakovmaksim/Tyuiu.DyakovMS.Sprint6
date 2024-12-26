using Tyuiu.DyakovMS.Sprint6.Task2.V29.Lib;

namespace Tyuiu.DyakovMS.Sprint6.Task2.V29.Test 
{ 
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 28.05;
            valueWaitArray[1] = 22.27;
            valueWaitArray[2] = 17.01;
            valueWaitArray[3] = 12.35;
            valueWaitArray[4] = 7.51;
            valueWaitArray[5] = 0;
            valueWaitArray[6] = 1.62;
            valueWaitArray[7] = -7.03;
            valueWaitArray[8] = -12.99;
            valueWaitArray[9] = -17.55;
            valueWaitArray[10] = -21.43;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            for (int i = 0; i < valueWaitArray.Length; i++)
            {
                Assert.AreEqual(valueWaitArray[i], res[i], 1e-2, $"Mismatch at index {i}: Expected = {valueWaitArray[i]}, Actual = {res[i]}");
            }
        }
    }
}