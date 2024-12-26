using Tyuiu.DyakovMS.Sprint6.Task3.V24.Lib;

namespace Tyuiu.DyakovMS.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -17, -6, 10, 5, 3 },
                                      { -10, -14, 10, -7, -3},
                                      { -19, 9, 8, -17, -9},
                                      { -19, -5, -9, -18, 14},
                                      { 17, 12, 11, 12, 2} };


        private void FormMain_load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridView_DMS.ColumnCount = columns;
            dataGridView_DMS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView_DMS.Columns[i].Width = 25;            
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_DMS.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_DMS_Click(object sender, EventArgs e)
        {
            dataGridView_DMS.Text = Convert.ToString(ds.Calculate(matrix));
        }

        private void buttonHelp_click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-24-1 Дьяков Максик Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
