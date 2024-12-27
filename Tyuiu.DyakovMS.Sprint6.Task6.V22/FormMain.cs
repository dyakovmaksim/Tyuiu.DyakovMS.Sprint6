using Tyuiu.DyakovMS.Sprint6.Task6.V22.Lib;

namespace Tyuiu.DyakovMS.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_DMS_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора файла
            if (openFileDialogTask_DMS.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask_DMS.FileName;

                // Считываем содержимое файла и отображаем в textBoxInput_DMS
                textBoxInput_DMS.Text = File.ReadAllText(openFilePath);

                // Очищаем textBoxResult_DMS
                textBoxResult_DMS.Clear();
            }
        }

        private void buttonDone_DMS_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(openFilePath) && File.Exists(openFilePath))
            {
                // Получаем результат из CollectTextFromFile
                string result = ds.CollectTextFromFile(openFilePath);

                // Выводим первые слова в textBoxResult_DMS
                textBoxResult_DMS.Text = result;
            }
            else
            {
                MessageBox.Show("Файл не выбран или путь недействителен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DMS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
