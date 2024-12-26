using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DyakovMS.Sprint6.Task3.V24.Lib
{
    public class DataService : ISprint6Task3V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            if (matrix.GetLength(0) > 1)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if (matrix[1, i] % 2 == 0)
                    {
                        matrix[1, i] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
