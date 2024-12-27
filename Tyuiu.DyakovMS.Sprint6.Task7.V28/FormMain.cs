using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.DyakovMS.Sprint6.Task6.V22;
using Tyuiu.DyakovMS.Sprint6.Task7.V28.Lib;

namespace Tyuiu.DyakovMS.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static string openFilePath;
        static int rows;
        static int columns;
        private int[,] modifiedMatrix;

        DataService dataService = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonDone_DMS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = dataService.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_DMS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_DMS.Enabled = true;
        }

        private void buttonHelp_DMS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_DMS_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_DMS.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogTask_DMS.FileName;

                modifiedMatrix = dataService.GetMatrix(filePath);

                int rows = modifiedMatrix.GetLength(0);
                int columns = modifiedMatrix.GetLength(1);

                dataGridViewInMatrix_DMS.ColumnCount = columns;
                dataGridViewInMatrix_DMS.RowCount = rows;
                dataGridViewOutMatrix_DMS.ColumnCount = columns;
                dataGridViewOutMatrix_DMS.RowCount = rows;

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewInMatrix_DMS.Rows[r].Cells[c].Value = modifiedMatrix[r, c];
                        dataGridViewOutMatrix_DMS.Rows[r].Cells[c].Value = modifiedMatrix[r, c];
                    }
                }

                buttonSave_DMS.Enabled = true;
            }
        }

        private void buttonSave_DMS_Click(object sender, EventArgs e)
        {
            if (saveFileDialogMatrix.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialogMatrix.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    int rows = modifiedMatrix.GetLength(0);
                    int columns = modifiedMatrix.GetLength(1);

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            writer.Write(modifiedMatrix[r, c]);
                            if (c < columns - 1)
                            {
                                writer.Write(";");
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        private void buttonOpenFile_DMS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMS.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_DMS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMS.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_DMS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMS.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_DMS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_DMS.ToolTipTitle = "Справка";
        }

        private void textBoxTask_DMS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
