namespace Tyuiu.DyakovMS.Sprint6.Task3.V24
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
            groupBoxTask_DMS = new GroupBox();
            dataGridView_DMS = new DataGridView();
            textBoxTask_DMS = new TextBox();
            buttonDone_DMS = new Button();
            buttonHelp_DMS = new Button();
            groupBoxTask_DMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DMS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_DMS
            // 
            groupBoxTask_DMS.Controls.Add(dataGridView_DMS);
            groupBoxTask_DMS.Controls.Add(textBoxTask_DMS);
            groupBoxTask_DMS.Location = new Point(12, 12);
            groupBoxTask_DMS.Name = "groupBoxTask_DMS";
            groupBoxTask_DMS.Size = new Size(585, 306);
            groupBoxTask_DMS.TabIndex = 0;
            groupBoxTask_DMS.TabStop = false;
            groupBoxTask_DMS.Text = "Условие";
            // 
            // dataGridView_DMS
            // 
            dataGridView_DMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_DMS.ColumnHeadersVisible = false;
            dataGridView_DMS.Location = new Point(302, 22);
            dataGridView_DMS.Name = "dataGridView_DMS";
            dataGridView_DMS.RowHeadersVisible = false;
            dataGridView_DMS.Size = new Size(271, 268);
            dataGridView_DMS.TabIndex = 4;
            // 
            // textBoxTask_DMS
            // 
            textBoxTask_DMS.Location = new Point(7, 22);
            textBoxTask_DMS.Multiline = true;
            textBoxTask_DMS.Name = "textBoxTask_DMS";
            textBoxTask_DMS.ReadOnly = true;
            textBoxTask_DMS.Size = new Size(290, 268);
            textBoxTask_DMS.TabIndex = 0;
            textBoxTask_DMS.Text = "Дан массив 5 на 5 элементов. \r\nЗаменить четные значения во второй строке на 0. \r\n-17  -6  10   5   3\r\n-10 -14  10  -7  -3\r\n -19   9   8 -17  -9\r\n -19  -5  -9 -18  14\r\n  17  12  11  12   2";
            textBoxTask_DMS.TextChanged += textBox1_TextChanged;
            // 
            // buttonDone_DMS
            // 
            buttonDone_DMS.Location = new Point(677, 282);
            buttonDone_DMS.Name = "buttonDone_DMS";
            buttonDone_DMS.Size = new Size(120, 36);
            buttonDone_DMS.TabIndex = 2;
            buttonDone_DMS.Text = "Выполнить";
            buttonDone_DMS.UseVisualStyleBackColor = true;
            buttonDone_DMS.Click += buttonDone_DMS_Click;
            // 
            // buttonHelp_DMS
            // 
            buttonHelp_DMS.Location = new Point(629, 282);
            buttonHelp_DMS.Name = "buttonHelp_DMS";
            buttonHelp_DMS.Size = new Size(42, 36);
            buttonHelp_DMS.TabIndex = 3;
            buttonHelp_DMS.Text = "?";
            buttonHelp_DMS.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 347);
            Controls.Add(buttonHelp_DMS);
            Controls.Add(buttonDone_DMS);
            Controls.Add(groupBoxTask_DMS);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_load;
            groupBoxTask_DMS.ResumeLayout(false);
            groupBoxTask_DMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_DMS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_DMS;
        private TextBox textBoxTask_DMS;
        private Button buttonDone_DMS;
        private Button buttonHelp_DMS;
        private DataGridView dataGridView_DMS;
    }
}
