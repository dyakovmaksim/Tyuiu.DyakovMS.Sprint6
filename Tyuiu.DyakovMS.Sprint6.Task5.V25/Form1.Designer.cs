namespace Tyuiu.DyakovMS.Sprint6.Task5.V25
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_DMS = new GroupBox();
            textBoxTask_DMS = new TextBox();
            buttonDone_DMS = new Button();
            buttonOpenFile_DMS = new Button();
            buttonHelp_DMS = new Button();
            dataGridViewNums_DMS = new DataGridView();
            labelResult_DMS = new Label();
            chartDiag_DMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_DMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_DMS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_DMS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_DMS
            // 
            groupBoxTask_DMS.Controls.Add(textBoxTask_DMS);
            groupBoxTask_DMS.Location = new Point(0, 1);
            groupBoxTask_DMS.Name = "groupBoxTask_DMS";
            groupBoxTask_DMS.Size = new Size(539, 72);
            groupBoxTask_DMS.TabIndex = 0;
            groupBoxTask_DMS.TabStop = false;
            groupBoxTask_DMS.Text = "Условие:";
            // 
            // textBoxTask_DMS
            // 
            textBoxTask_DMS.Location = new Point(6, 22);
            textBoxTask_DMS.Multiline = true;
            textBoxTask_DMS.Name = "textBoxTask_DMS";
            textBoxTask_DMS.ReadOnly = true;
            textBoxTask_DMS.Size = new Size(527, 44);
            textBoxTask_DMS.TabIndex = 0;
            textBoxTask_DMS.Text = "Прочитать данные из файла InPutFileTask5V25.txt. Вывести в dataGridView. \r\nДан список из чисел. Вывести все числа, не равные 0.";
            // 
            // buttonDone_DMS
            // 
            buttonDone_DMS.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_DMS.Location = new Point(545, 12);
            buttonDone_DMS.Name = "buttonDone_DMS";
            buttonDone_DMS.Size = new Size(103, 61);
            buttonDone_DMS.TabIndex = 1;
            buttonDone_DMS.Text = "Выполнить";
            buttonDone_DMS.UseVisualStyleBackColor = false;
            buttonDone_DMS.Click += buttonDone_DMS_Click;
            // 
            // buttonOpenFile_DMS
            // 
            buttonOpenFile_DMS.BackColor = Color.Cyan;
            buttonOpenFile_DMS.Location = new Point(654, 12);
            buttonOpenFile_DMS.Name = "buttonOpenFile_DMS";
            buttonOpenFile_DMS.Size = new Size(103, 61);
            buttonOpenFile_DMS.TabIndex = 2;
            buttonOpenFile_DMS.Text = "Открыть файл";
            buttonOpenFile_DMS.UseVisualStyleBackColor = false;
            buttonOpenFile_DMS.Click += buttonOpenFile_DMS_Click;
            // 
            // buttonHelp_DMS
            // 
            buttonHelp_DMS.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_DMS.Location = new Point(763, 12);
            buttonHelp_DMS.Name = "buttonHelp_DMS";
            buttonHelp_DMS.Size = new Size(103, 61);
            buttonHelp_DMS.TabIndex = 3;
            buttonHelp_DMS.Text = "Справка";
            buttonHelp_DMS.UseVisualStyleBackColor = false;
            buttonHelp_DMS.Click += buttonHelp_DMS_Click;
            // 
            // dataGridViewNums_DMS
            // 
            dataGridViewNums_DMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_DMS.ColumnHeadersVisible = false;
            dataGridViewNums_DMS.Location = new Point(0, 94);
            dataGridViewNums_DMS.Name = "dataGridViewNums_DMS";
            dataGridViewNums_DMS.RowHeadersVisible = false;
            dataGridViewNums_DMS.Size = new Size(240, 411);
            dataGridViewNums_DMS.TabIndex = 4;
            // 
            // labelResult_DMS
            // 
            labelResult_DMS.AutoSize = true;
            labelResult_DMS.Location = new Point(6, 76);
            labelResult_DMS.Name = "labelResult_DMS";
            labelResult_DMS.Size = new Size(89, 15);
            labelResult_DMS.TabIndex = 5;
            labelResult_DMS.Text = "Вывод данных:";
            // 
            // chartDiag_DMS
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_DMS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_DMS.Legends.Add(legend1);
            chartDiag_DMS.Location = new Point(246, 73);
            chartDiag_DMS.Name = "chartDiag_DMS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_DMS.Series.Add(series1);
            chartDiag_DMS.Size = new Size(765, 432);
            chartDiag_DMS.TabIndex = 6;
            chartDiag_DMS.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 517);
            Controls.Add(chartDiag_DMS);
            Controls.Add(labelResult_DMS);
            Controls.Add(dataGridViewNums_DMS);
            Controls.Add(buttonHelp_DMS);
            Controls.Add(buttonOpenFile_DMS);
            Controls.Add(buttonDone_DMS);
            Controls.Add(groupBoxTask_DMS);
            Name = "Form1";
            Text = "Form1";
            groupBoxTask_DMS.ResumeLayout(false);
            groupBoxTask_DMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_DMS).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_DMS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask_DMS;
        private TextBox textBoxTask_DMS;
        private Button buttonDone_DMS;
        private Button buttonOpenFile_DMS;
        private Button buttonHelp_DMS;
        private DataGridView dataGridViewNums_DMS;
        private Label labelResult_DMS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_DMS;
    }
}
