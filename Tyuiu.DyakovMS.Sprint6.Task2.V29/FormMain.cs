using Tyuiu.DyakovMS.Sprint6.Task2.V29.Lib;

namespace Tyuiu.DyakovMS.Sprint6.Task2.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_DMS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_DMS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_DMS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_DMS.Titles.Add("График функции");

                this.chartFunction_DMS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_DMS.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_DMS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_DMS.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-24-1 Дьяков Максим Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_DMS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_DMS.BackColor = Color.Red;
        }

        private void buttonDone_DMS_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_DMS.BackColor = Color.Green;
        }
        private void buttonDone_DMS_MouseDown(object sender, EventArgs e)
        {
            buttonDone_DMS.BackColor = Color.Blue;
        }
    }
}
