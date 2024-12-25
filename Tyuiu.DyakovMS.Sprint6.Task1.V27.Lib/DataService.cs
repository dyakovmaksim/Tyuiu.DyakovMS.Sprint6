using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DyakovMS.Sprint6.Task1.V27.Lib
{
    public class DataService : ISprint6Task1V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 1 || (2 * x - 2) == 0)
                {
                    y = 0; 
                }
                else
                {
                    y = Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2), 2);
                }
                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
