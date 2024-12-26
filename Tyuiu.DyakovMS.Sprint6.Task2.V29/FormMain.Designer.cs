namespace Tyuiu.DyakovMS.Sprint6.Task2.V29
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_DMS = new GroupBox();
            pictureBoxTask_DMS = new PictureBox();
            groupBoxValue_DMS = new GroupBox();
            textBoxStopStep_DMS = new TextBox();
            textBoxStartStep_DMS = new TextBox();
            labelStopStep_DMS = new Label();
            labelStartStep_DMS = new Label();
            groupBoxResult_DMS = new GroupBox();
            chartFunction_DMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_DMS = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            labelResult_DMS = new Label();
            buttonHelp_DMS = new Button();
            buttonDone_DMS = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxTask_DMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_DMS).BeginInit();
            groupBoxValue_DMS.SuspendLayout();
            groupBoxResult_DMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_DMS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_DMS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_DMS
            // 
            groupBoxTask_DMS.Controls.Add(pictureBoxTask_DMS);
            groupBoxTask_DMS.Location = new Point(12, 12);
            groupBoxTask_DMS.Name = "groupBoxTask_DMS";
            groupBoxTask_DMS.Size = new Size(518, 345);
            groupBoxTask_DMS.TabIndex = 0;
            groupBoxTask_DMS.TabStop = false;
            groupBoxTask_DMS.Text = "Условие";
            // 
            // pictureBoxTask_DMS
            // 
            pictureBoxTask_DMS.Image = (Image)resources.GetObject("pictureBoxTask_DMS.Image");
            pictureBoxTask_DMS.Location = new Point(6, 22);
            pictureBoxTask_DMS.Name = "pictureBoxTask_DMS";
            pictureBoxTask_DMS.Size = new Size(506, 168);
            pictureBoxTask_DMS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_DMS.TabIndex = 0;
            pictureBoxTask_DMS.TabStop = false;
            // 
            // groupBoxValue_DMS
            // 
            groupBoxValue_DMS.Controls.Add(textBoxStopStep_DMS);
            groupBoxValue_DMS.Controls.Add(textBoxStartStep_DMS);
            groupBoxValue_DMS.Controls.Add(labelStopStep_DMS);
            groupBoxValue_DMS.Controls.Add(labelStartStep_DMS);
            groupBoxValue_DMS.Location = new Point(12, 363);
            groupBoxValue_DMS.Name = "groupBoxValue_DMS";
            groupBoxValue_DMS.Size = new Size(269, 75);
            groupBoxValue_DMS.TabIndex = 0;
            groupBoxValue_DMS.TabStop = false;
            groupBoxValue_DMS.Text = "Ввод данных";
            // 
            // textBoxStopStep_DMS
            // 
            textBoxStopStep_DMS.Location = new Point(141, 37);
            textBoxStopStep_DMS.Name = "textBoxStopStep_DMS";
            textBoxStopStep_DMS.Size = new Size(122, 23);
            textBoxStopStep_DMS.TabIndex = 2;
            // 
            // textBoxStartStep_DMS
            // 
            textBoxStartStep_DMS.Location = new Point(6, 37);
            textBoxStartStep_DMS.Name = "textBoxStartStep_DMS";
            textBoxStartStep_DMS.Size = new Size(122, 23);
            textBoxStartStep_DMS.TabIndex = 1;
            // 
            // labelStopStep_DMS
            // 
            labelStopStep_DMS.AutoSize = true;
            labelStopStep_DMS.Location = new Point(141, 19);
            labelStopStep_DMS.Name = "labelStopStep_DMS";
            labelStopStep_DMS.Size = new Size(75, 15);
            labelStopStep_DMS.TabIndex = 1;
            labelStopStep_DMS.Text = "Конец шага:";
            // 
            // labelStartStep_DMS
            // 
            labelStartStep_DMS.AutoSize = true;
            labelStartStep_DMS.Location = new Point(6, 19);
            labelStartStep_DMS.Name = "labelStartStep_DMS";
            labelStartStep_DMS.Size = new Size(72, 15);
            labelStartStep_DMS.TabIndex = 0;
            labelStartStep_DMS.Text = "Старт шага:";
            // 
            // groupBoxResult_DMS
            // 
            groupBoxResult_DMS.Controls.Add(chartFunction_DMS);
            groupBoxResult_DMS.Controls.Add(dataGridViewFunction_DMS);
            groupBoxResult_DMS.Controls.Add(labelResult_DMS);
            groupBoxResult_DMS.Location = new Point(536, 12);
            groupBoxResult_DMS.Name = "groupBoxResult_DMS";
            groupBoxResult_DMS.Size = new Size(507, 426);
            groupBoxResult_DMS.TabIndex = 0;
            groupBoxResult_DMS.TabStop = false;
            groupBoxResult_DMS.Text = "Вывод данных";
            // 
            // chartFunction_DMS
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_DMS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_DMS.Legends.Add(legend1);
            chartFunction_DMS.Location = new Point(138, 40);
            chartFunction_DMS.Name = "chartFunction_DMS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_DMS.Series.Add(series1);
            chartFunction_DMS.Size = new Size(363, 371);
            chartFunction_DMS.TabIndex = 3;
            chartFunction_DMS.Text = "chart1";
            // 
            // dataGridViewFunction_DMS
            // 
            dataGridViewFunction_DMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_DMS.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_DMS.Location = new Point(6, 40);
            dataGridViewFunction_DMS.Name = "dataGridViewFunction_DMS";
            dataGridViewFunction_DMS.RowHeadersVisible = false;
            dataGridViewFunction_DMS.ScrollBars = ScrollBars.Vertical;
            dataGridViewFunction_DMS.Size = new Size(126, 371);
            dataGridViewFunction_DMS.TabIndex = 3;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // labelResult_DMS
            // 
            labelResult_DMS.AutoSize = true;
            labelResult_DMS.Location = new Point(6, 19);
            labelResult_DMS.Name = "labelResult_DMS";
            labelResult_DMS.Size = new Size(63, 15);
            labelResult_DMS.TabIndex = 2;
            labelResult_DMS.Text = "Результат:";
            // 
            // buttonHelp_DMS
            // 
            buttonHelp_DMS.BackColor = SystemColors.Highlight;
            buttonHelp_DMS.Location = new Point(287, 363);
            buttonHelp_DMS.Name = "buttonHelp_DMS";
            buttonHelp_DMS.Size = new Size(99, 75);
            buttonHelp_DMS.TabIndex = 1;
            buttonHelp_DMS.Text = "Справка";
            buttonHelp_DMS.UseVisualStyleBackColor = false;
            buttonHelp_DMS.Click += buttonHelp_DMS_Click;
            // 
            // buttonDone_DMS
            // 
            buttonDone_DMS.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_DMS.ForeColor = SystemColors.ControlText;
            buttonDone_DMS.Location = new Point(392, 363);
            buttonDone_DMS.Name = "buttonDone_DMS";
            buttonDone_DMS.Size = new Size(138, 75);
            buttonDone_DMS.TabIndex = 2;
            buttonDone_DMS.Text = "Выполнить";
            buttonDone_DMS.UseVisualStyleBackColor = false;
            buttonDone_DMS.Click += buttonDone_DMS_Click;
            buttonDone_DMS.MouseEnter += buttonDone_DMS_MouseEnter;
            buttonDone_DMS.MouseLeave += buttonDone_DMS_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 450);
            Controls.Add(buttonDone_DMS);
            Controls.Add(buttonHelp_DMS);
            Controls.Add(groupBoxResult_DMS);
            Controls.Add(groupBoxValue_DMS);
            Controls.Add(groupBoxTask_DMS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 29 | Дьяков М. С.";
            groupBoxTask_DMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_DMS).EndInit();
            groupBoxValue_DMS.ResumeLayout(false);
            groupBoxValue_DMS.PerformLayout();
            groupBoxResult_DMS.ResumeLayout(false);
            groupBoxResult_DMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_DMS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_DMS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_DMS;
        private PictureBox pictureBoxTask_DMS;
        private GroupBox groupBoxValue_DMS;
        private TextBox textBoxStartStep_DMS;
        private Label labelStopStep_DMS;
        private Label labelStartStep_DMS;
        private GroupBox groupBoxResult_DMS;
        private Label labelResult_DMS;
        private TextBox textBoxStopStep_DMS;
        private Button buttonHelp_DMS;
        private Button buttonDone_DMS;
        private DataGridView dataGridViewFunction_DMS;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DMS;
    }
}
