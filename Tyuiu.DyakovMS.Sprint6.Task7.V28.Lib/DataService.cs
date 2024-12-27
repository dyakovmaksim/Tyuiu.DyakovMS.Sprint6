using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DyakovMS.Sprint6.Task7.V28.Lib
{
    public class DataService : ISprint6Task7V28
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] values = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToInt32(values[c]);
                }
            }

            if (rows >= 7)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (matrix[6, c] != 13)
                    {
                        matrix[6, c] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}
