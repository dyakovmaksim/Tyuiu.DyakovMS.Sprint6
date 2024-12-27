using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DyakovMS.Sprint6.Task5.V25.Lib
{
    public class DataService : ISprint6Task5V25
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = Console.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = Console.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            numsArray = numsArray
                .Where(val => Math.Abs(val) > 0.0001)
                .Select(val => Math.Round(val, 3))
                .ToArray();

            return numsArray;
        }
    }
}
