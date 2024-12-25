using Tyuiu.DyakovMS.Sprint6.Task0.V17.Lib;

namespace Tyuiu.DyakovMS.Sprint6.Task0.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_DMS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_DMS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxValueX_DMS.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DMS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-24-1 Дьяков Максим Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFormula_DMS_Click(object sender, EventArgs e)
        {

        }
    }
}
