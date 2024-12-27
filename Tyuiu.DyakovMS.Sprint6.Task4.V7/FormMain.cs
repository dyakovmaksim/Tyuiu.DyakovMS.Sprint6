using Tyuiu.DyakovMS.Sprint6.Task4.V7.Lib;

namespace Tyuiu.DyakovMS.Sprint6.Task4.V7
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

                this.chartFunction_DMS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_DMS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_DMS.Text = "";

                chartFunction_DMS.Series[0].Points.Clear();
                for (int i = 0; i < len - 1; i++)
                {
                    this.chartFunction_DMS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_DMS.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch 
            { 
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );            
            }
        }
    }
}
