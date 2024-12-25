namespace Tyuiu.DyakovMS.Sprint6.Task0.V17
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
            groupBoxTask_DMS = new GroupBox();
            textBoxTask_DMS = new TextBox();
            groupBoxValue_DMS = new GroupBox();
            label1 = new Label();
            textBoxValueX_DMS = new TextBox();
            groupBoxResult_DMS = new GroupBox();
            label2 = new Label();
            textBoxResult_DMS = new TextBox();
            pictureBoxFormula_DMS = new PictureBox();
            buttonDone_DMS = new Button();
            buttonHelp_DMS = new Button();
            groupBoxTask_DMS.SuspendLayout();
            groupBoxValue_DMS.SuspendLayout();
            groupBoxResult_DMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_DMS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_DMS
            // 
            groupBoxTask_DMS.Controls.Add(textBoxTask_DMS);
            groupBoxTask_DMS.Location = new Point(12, 12);
            groupBoxTask_DMS.Name = "groupBoxTask_DMS";
            groupBoxTask_DMS.Size = new Size(482, 192);
            groupBoxTask_DMS.TabIndex = 0;
            groupBoxTask_DMS.TabStop = false;
            groupBoxTask_DMS.Text = "Условие";
            // 
            // textBoxTask_DMS
            // 
            textBoxTask_DMS.BorderStyle = BorderStyle.None;
            textBoxTask_DMS.Location = new Point(6, 22);
            textBoxTask_DMS.Multiline = true;
            textBoxTask_DMS.Name = "textBoxTask_DMS";
            textBoxTask_DMS.ReadOnly = true;
            textBoxTask_DMS.Size = new Size(470, 164);
            textBoxTask_DMS.TabIndex = 0;
            textBoxTask_DMS.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxValue_DMS
            // 
            groupBoxValue_DMS.Controls.Add(label1);
            groupBoxValue_DMS.Controls.Add(textBoxValueX_DMS);
            groupBoxValue_DMS.Location = new Point(12, 236);
            groupBoxValue_DMS.Name = "groupBoxValue_DMS";
            groupBoxValue_DMS.Size = new Size(482, 115);
            groupBoxValue_DMS.TabIndex = 0;
            groupBoxValue_DMS.TabStop = false;
            groupBoxValue_DMS.Text = "Ввод данных";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Значение X:";
            label1.Click += label1_Click;
            // 
            // textBoxValueX_DMS
            // 
            textBoxValueX_DMS.Location = new Point(6, 48);
            textBoxValueX_DMS.Name = "textBoxValueX_DMS";
            textBoxValueX_DMS.Size = new Size(116, 23);
            textBoxValueX_DMS.TabIndex = 3;
            // 
            // groupBoxResult_DMS
            // 
            groupBoxResult_DMS.Controls.Add(label2);
            groupBoxResult_DMS.Controls.Add(textBoxResult_DMS);
            groupBoxResult_DMS.Location = new Point(500, 236);
            groupBoxResult_DMS.Name = "groupBoxResult_DMS";
            groupBoxResult_DMS.Size = new Size(288, 115);
            groupBoxResult_DMS.TabIndex = 0;
            groupBoxResult_DMS.TabStop = false;
            groupBoxResult_DMS.Text = "Вывод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Результат:";
            label2.Click += label2_Click;
            // 
            // textBoxResult_DMS
            // 
            textBoxResult_DMS.Location = new Point(6, 48);
            textBoxResult_DMS.Name = "textBoxResult_DMS";
            textBoxResult_DMS.ReadOnly = true;
            textBoxResult_DMS.Size = new Size(276, 23);
            textBoxResult_DMS.TabIndex = 3;
            // 
            // pictureBoxFormula_DMS
            // 
            pictureBoxFormula_DMS.Image = (Image)resources.GetObject("pictureBoxFormula_DMS.Image");
            pictureBoxFormula_DMS.Location = new Point(614, 34);
            pictureBoxFormula_DMS.Name = "pictureBoxFormula_DMS";
            pictureBoxFormula_DMS.Size = new Size(76, 56);
            pictureBoxFormula_DMS.TabIndex = 1;
            pictureBoxFormula_DMS.TabStop = false;
            pictureBoxFormula_DMS.Click += pictureBoxFormula_DMS_Click;
            // 
            // buttonDone_DMS
            // 
            buttonDone_DMS.Location = new Point(565, 357);
            buttonDone_DMS.Name = "buttonDone_DMS";
            buttonDone_DMS.Size = new Size(217, 81);
            buttonDone_DMS.TabIndex = 4;
            buttonDone_DMS.Text = "Выполнить";
            buttonDone_DMS.UseVisualStyleBackColor = true;
            buttonDone_DMS.Click += buttonDone_DMS_Click;
            // 
            // buttonHelp_DMS
            // 
            buttonHelp_DMS.FlatStyle = FlatStyle.Flat;
            buttonHelp_DMS.Location = new Point(506, 357);
            buttonHelp_DMS.Name = "buttonHelp_DMS";
            buttonHelp_DMS.Size = new Size(53, 81);
            buttonHelp_DMS.TabIndex = 5;
            buttonHelp_DMS.Text = "?";
            buttonHelp_DMS.UseVisualStyleBackColor = true;
            buttonHelp_DMS.Click += buttonHelp_DMS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_DMS);
            Controls.Add(buttonDone_DMS);
            Controls.Add(pictureBoxFormula_DMS);
            Controls.Add(groupBoxResult_DMS);
            Controls.Add(groupBoxValue_DMS);
            Controls.Add(groupBoxTask_DMS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 17 | Дьяков М. С. ";
            groupBoxTask_DMS.ResumeLayout(false);
            groupBoxTask_DMS.PerformLayout();
            groupBoxValue_DMS.ResumeLayout(false);
            groupBoxValue_DMS.PerformLayout();
            groupBoxResult_DMS.ResumeLayout(false);
            groupBoxResult_DMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_DMS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_DMS;
        private GroupBox groupBoxValue_DMS;
        private GroupBox groupBoxResult_DMS;
        private TextBox textBoxResult_DMS;
        private PictureBox pictureBoxFormula_DMS;
        private Button buttonDone_DMS;
        private TextBox textBoxValueX_DMS;
        private TextBox textBoxTask_DMS;
        private Label label1;
        private Label label2;
        private Button buttonHelp_DMS;
    }
}
