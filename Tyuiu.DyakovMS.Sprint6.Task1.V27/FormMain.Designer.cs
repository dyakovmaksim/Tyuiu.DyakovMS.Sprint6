
namespace Tyuiu.DyakovMS.Sprint6.Task1.V27
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
            pictureBox_DMS = new PictureBox();
            groupBoxResult_DMS = new GroupBox();
            textBoxResult_DMS = new TextBox();
            labelResult_DMS = new Label();
            groupBoxValue_DMS = new GroupBox();
            textBoxEndVar_DMS = new TextBox();
            textBoxStartVar_DMS = new TextBox();
            labelEnd_DMS = new Label();
            labelStart_DMS = new Label();
            buttonHelp_DMS = new Button();
            buttonDone_DMS = new Button();
            groupBoxTask_DMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DMS).BeginInit();
            groupBoxResult_DMS.SuspendLayout();
            groupBoxValue_DMS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_DMS
            // 
            groupBoxTask_DMS.Controls.Add(pictureBox_DMS);
            groupBoxTask_DMS.Location = new Point(12, 12);
            groupBoxTask_DMS.Name = "groupBoxTask_DMS";
            groupBoxTask_DMS.Size = new Size(542, 320);
            groupBoxTask_DMS.TabIndex = 0;
            groupBoxTask_DMS.TabStop = false;
            groupBoxTask_DMS.Text = "Условие";
            // 
            // pictureBox_DMS
            // 
            pictureBox_DMS.Image = (Image)resources.GetObject("pictureBox_DMS.Image");
            pictureBox_DMS.Location = new Point(0, 22);
            pictureBox_DMS.Name = "pictureBox_DMS";
            pictureBox_DMS.Size = new Size(536, 154);
            pictureBox_DMS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_DMS.TabIndex = 0;
            pictureBox_DMS.TabStop = false;
            // 
            // groupBoxResult_DMS
            // 
            groupBoxResult_DMS.Controls.Add(textBoxResult_DMS);
            groupBoxResult_DMS.Controls.Add(labelResult_DMS);
            groupBoxResult_DMS.Location = new Point(560, 12);
            groupBoxResult_DMS.Name = "groupBoxResult_DMS";
            groupBoxResult_DMS.Size = new Size(228, 426);
            groupBoxResult_DMS.TabIndex = 0;
            groupBoxResult_DMS.TabStop = false;
            groupBoxResult_DMS.Text = "Вывод данных";
            // 
            // textBoxResult_DMS
            // 
            textBoxResult_DMS.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult_DMS.Location = new Point(6, 37);
            textBoxResult_DMS.Multiline = true;
            textBoxResult_DMS.Name = "textBoxResult_DMS";
            textBoxResult_DMS.ReadOnly = true;
            textBoxResult_DMS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DMS.Size = new Size(216, 383);
            textBoxResult_DMS.TabIndex = 1;
            textBoxResult_DMS.TextChanged += textBoxResult_DMS_TextChanged;
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
            // groupBoxValue_DMS
            // 
            groupBoxValue_DMS.Controls.Add(textBoxEndVar_DMS);
            groupBoxValue_DMS.Controls.Add(textBoxStartVar_DMS);
            groupBoxValue_DMS.Controls.Add(labelEnd_DMS);
            groupBoxValue_DMS.Controls.Add(labelStart_DMS);
            groupBoxValue_DMS.Location = new Point(12, 338);
            groupBoxValue_DMS.Name = "groupBoxValue_DMS";
            groupBoxValue_DMS.Size = new Size(266, 100);
            groupBoxValue_DMS.TabIndex = 1;
            groupBoxValue_DMS.TabStop = false;
            groupBoxValue_DMS.Text = "Ввод данных";
            // 
            // textBoxEndVar_DMS
            // 
            textBoxEndVar_DMS.Location = new Point(138, 37);
            textBoxEndVar_DMS.Name = "textBoxEndVar_DMS";
            textBoxEndVar_DMS.Size = new Size(100, 23);
            textBoxEndVar_DMS.TabIndex = 3;
            // 
            // textBoxStartVar_DMS
            // 
            textBoxStartVar_DMS.Location = new Point(6, 37);
            textBoxStartVar_DMS.Name = "textBoxStartVar_DMS";
            textBoxStartVar_DMS.Size = new Size(100, 23);
            textBoxStartVar_DMS.TabIndex = 2;
            // 
            // labelEnd_DMS
            // 
            labelEnd_DMS.AutoSize = true;
            labelEnd_DMS.Location = new Point(138, 19);
            labelEnd_DMS.Name = "labelEnd_DMS";
            labelEnd_DMS.Size = new Size(75, 15);
            labelEnd_DMS.TabIndex = 1;
            labelEnd_DMS.Text = "Конец шага:";
            // 
            // labelStart_DMS
            // 
            labelStart_DMS.AutoSize = true;
            labelStart_DMS.Location = new Point(6, 19);
            labelStart_DMS.Name = "labelStart_DMS";
            labelStart_DMS.Size = new Size(72, 15);
            labelStart_DMS.TabIndex = 0;
            labelStart_DMS.Text = "Старт шага:";
            // 
            // buttonHelp_DMS
            // 
            buttonHelp_DMS.BackColor = SystemColors.MenuHighlight;
            buttonHelp_DMS.ForeColor = SystemColors.ControlText;
            buttonHelp_DMS.Location = new Point(293, 338);
            buttonHelp_DMS.Name = "buttonHelp_DMS";
            buttonHelp_DMS.Size = new Size(120, 100);
            buttonHelp_DMS.TabIndex = 2;
            buttonHelp_DMS.Text = "Справка";
            buttonHelp_DMS.UseVisualStyleBackColor = false;
            buttonHelp_DMS.Click += buttonHelp_DMS_Click;
            // 
            // buttonDone_DMS
            // 
            buttonDone_DMS.BackColor = Color.Lime;
            buttonDone_DMS.Location = new Point(419, 338);
            buttonDone_DMS.Name = "buttonDone_DMS";
            buttonDone_DMS.Size = new Size(135, 100);
            buttonDone_DMS.TabIndex = 3;
            buttonDone_DMS.Text = "Выполнить";
            buttonDone_DMS.UseVisualStyleBackColor = false;
            buttonDone_DMS.Click += buttonDone_DMS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_DMS);
            Controls.Add(buttonHelp_DMS);
            Controls.Add(groupBoxValue_DMS);
            Controls.Add(groupBoxResult_DMS);
            Controls.Add(groupBoxTask_DMS);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 27  | Дьяков М. С. ";
            groupBoxTask_DMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_DMS).EndInit();
            groupBoxResult_DMS.ResumeLayout(false);
            groupBoxResult_DMS.PerformLayout();
            groupBoxValue_DMS.ResumeLayout(false);
            groupBoxValue_DMS.PerformLayout();
            ResumeLayout(false);
        }

        private void textBoxResult_DMS_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBoxTask_DMS;
        private GroupBox groupBoxResult_DMS;
        private GroupBox groupBoxValue_DMS;
        private PictureBox pictureBox_DMS;
        private Label labelEnd_DMS;
        private Label labelStart_DMS;
        private TextBox textBoxResult_DMS;
        private TextBox textBoxEndVar_DMS;
        private TextBox textBoxStartVar_DMS;
        private Button buttonHelp_DMS;
        private Button buttonDone_DMS;
        private Label labelResult_DMS;
    }
}
