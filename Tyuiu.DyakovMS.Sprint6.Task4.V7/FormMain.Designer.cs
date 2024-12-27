namespace Tyuiu.DyakovMS.Sprint6.Task4.V7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_DMS = new GroupBox();
            textBox1 = new TextBox();
            groupBoxValue_DMS = new GroupBox();
            textBoxStopStep_DMS = new TextBox();
            textBoxStartStep_DMS = new TextBox();
            labelStopStep_DMS = new Label();
            labelStartStep_DMS = new Label();
            buttonDone_DMS = new Button();
            buttonSave_DMS = new Button();
            buttonHelp_DMS = new Button();
            groupBoxResult_DMS = new GroupBox();
            textBoxResult_DMS = new TextBox();
            chartFunction_DMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_DMS.SuspendLayout();
            groupBoxValue_DMS.SuspendLayout();
            groupBoxResult_DMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_DMS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_DMS
            // 
            groupBoxTask_DMS.Controls.Add(textBox1);
            groupBoxTask_DMS.Location = new Point(12, 12);
            groupBoxTask_DMS.Name = "groupBoxTask_DMS";
            groupBoxTask_DMS.Size = new Size(394, 60);
            groupBoxTask_DMS.TabIndex = 0;
            groupBoxTask_DMS.TabStop = false;
            groupBoxTask_DMS.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 16);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(382, 38);
            textBox1.TabIndex = 4;
            textBox1.Text = "Протабулировать фурнкцию на заданом диапазоне.\r\nПостроить график функции и сохранить в файл.";
            // 
            // groupBoxValue_DMS
            // 
            groupBoxValue_DMS.Controls.Add(textBoxStopStep_DMS);
            groupBoxValue_DMS.Controls.Add(textBoxStartStep_DMS);
            groupBoxValue_DMS.Controls.Add(labelStopStep_DMS);
            groupBoxValue_DMS.Controls.Add(labelStartStep_DMS);
            groupBoxValue_DMS.Location = new Point(412, 12);
            groupBoxValue_DMS.Name = "groupBoxValue_DMS";
            groupBoxValue_DMS.Size = new Size(219, 60);
            groupBoxValue_DMS.TabIndex = 0;
            groupBoxValue_DMS.TabStop = false;
            groupBoxValue_DMS.Text = "Ввод данных";
            // 
            // textBoxStopStep_DMS
            // 
            textBoxStopStep_DMS.Location = new Point(112, 31);
            textBoxStopStep_DMS.Name = "textBoxStopStep_DMS";
            textBoxStopStep_DMS.Size = new Size(100, 23);
            textBoxStopStep_DMS.TabIndex = 4;
            // 
            // textBoxStartStep_DMS
            // 
            textBoxStartStep_DMS.Location = new Point(6, 31);
            textBoxStartStep_DMS.Name = "textBoxStartStep_DMS";
            textBoxStartStep_DMS.Size = new Size(100, 23);
            textBoxStartStep_DMS.TabIndex = 4;
            // 
            // labelStopStep_DMS
            // 
            labelStopStep_DMS.AutoSize = true;
            labelStopStep_DMS.Location = new Point(112, 13);
            labelStopStep_DMS.Name = "labelStopStep_DMS";
            labelStopStep_DMS.Size = new Size(75, 15);
            labelStopStep_DMS.TabIndex = 4;
            labelStopStep_DMS.Text = "Конец шага:";
            // 
            // labelStartStep_DMS
            // 
            labelStartStep_DMS.AutoSize = true;
            labelStartStep_DMS.Location = new Point(6, 13);
            labelStartStep_DMS.Name = "labelStartStep_DMS";
            labelStartStep_DMS.Size = new Size(72, 15);
            labelStartStep_DMS.TabIndex = 4;
            labelStartStep_DMS.Text = "Старт шага:";
            // 
            // buttonDone_DMS
            // 
            buttonDone_DMS.BackColor = Color.Lime;
            buttonDone_DMS.Location = new Point(637, 12);
            buttonDone_DMS.Name = "buttonDone_DMS";
            buttonDone_DMS.Size = new Size(114, 60);
            buttonDone_DMS.TabIndex = 1;
            buttonDone_DMS.Text = "Выполнить";
            buttonDone_DMS.UseVisualStyleBackColor = false;
            buttonDone_DMS.Click += buttonDone_DMS_Click;
            // 
            // buttonSave_DMS
            // 
            buttonSave_DMS.BackColor = Color.Cyan;
            buttonSave_DMS.Location = new Point(757, 12);
            buttonSave_DMS.Name = "buttonSave_DMS";
            buttonSave_DMS.Size = new Size(114, 60);
            buttonSave_DMS.TabIndex = 2;
            buttonSave_DMS.Text = "Сохранить";
            buttonSave_DMS.UseVisualStyleBackColor = false;
            // 
            // buttonHelp_DMS
            // 
            buttonHelp_DMS.BackColor = SystemColors.Highlight;
            buttonHelp_DMS.Location = new Point(980, 12);
            buttonHelp_DMS.Name = "buttonHelp_DMS";
            buttonHelp_DMS.Size = new Size(75, 60);
            buttonHelp_DMS.TabIndex = 3;
            buttonHelp_DMS.Text = "Справка";
            buttonHelp_DMS.UseVisualStyleBackColor = false;
            // 
            // groupBoxResult_DMS
            // 
            groupBoxResult_DMS.Controls.Add(textBoxResult_DMS);
            groupBoxResult_DMS.Location = new Point(12, 72);
            groupBoxResult_DMS.Name = "groupBoxResult_DMS";
            groupBoxResult_DMS.Size = new Size(247, 525);
            groupBoxResult_DMS.TabIndex = 4;
            groupBoxResult_DMS.TabStop = false;
            groupBoxResult_DMS.Text = "Вывод";
            // 
            // textBoxResult_DMS
            // 
            textBoxResult_DMS.Location = new Point(6, 22);
            textBoxResult_DMS.Multiline = true;
            textBoxResult_DMS.Name = "textBoxResult_DMS";
            textBoxResult_DMS.ReadOnly = true;
            textBoxResult_DMS.Size = new Size(235, 497);
            textBoxResult_DMS.TabIndex = 0;
            // 
            // chartFunction_DMS
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_DMS.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_DMS.Legends.Add(legend1);
            chartFunction_DMS.Location = new Point(265, 78);
            chartFunction_DMS.Name = "chartFunction_DMS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_DMS.Series.Add(series1);
            chartFunction_DMS.Size = new Size(790, 519);
            chartFunction_DMS.TabIndex = 1;
            chartFunction_DMS.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 609);
            Controls.Add(chartFunction_DMS);
            Controls.Add(groupBoxResult_DMS);
            Controls.Add(buttonHelp_DMS);
            Controls.Add(buttonSave_DMS);
            Controls.Add(buttonDone_DMS);
            Controls.Add(groupBoxValue_DMS);
            Controls.Add(groupBoxTask_DMS);
            Name = "FormMain";
            Text = "Form1";
            groupBoxTask_DMS.ResumeLayout(false);
            groupBoxTask_DMS.PerformLayout();
            groupBoxValue_DMS.ResumeLayout(false);
            groupBoxValue_DMS.PerformLayout();
            groupBoxResult_DMS.ResumeLayout(false);
            groupBoxResult_DMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_DMS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_DMS;
        private GroupBox groupBoxValue_DMS;
        private Button buttonDone_DMS;
        private Button buttonSave_DMS;
        private Button buttonHelp_DMS;
        private TextBox textBox1;
        private TextBox textBoxStartStep_DMS;
        private Label labelStopStep_DMS;
        private Label labelStartStep_DMS;
        private TextBox textBoxStopStep_DMS;
        private GroupBox groupBoxResult_DMS;
        private TextBox textBoxResult_DMS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DMS;
    }
}
