namespace Tyuiu.DyakovMS.Sprint6.Task7.V28
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp_DMS = new Button();
            buttonSave_DMS = new Button();
            buttonDone_DMS = new Button();
            buttonOpenFile_DMS = new Button();
            panel2 = new Panel();
            groupBoxTask_DMS = new GroupBox();
            textBoxTask_DMS = new TextBox();
            panel3 = new Panel();
            groupBoxInput_DMS = new GroupBox();
            dataGridViewInMatrix_DMS = new DataGridView();
            panel4 = new Panel();
            groupBoxResult_DMS = new GroupBox();
            dataGridViewOutMatrix_DMS = new DataGridView();
            splitter1 = new Splitter();
            openFileDialogTask_DMS = new OpenFileDialog();
            toolTip_DMS = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTask_DMS.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxInput_DMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_DMS).BeginInit();
            panel4.SuspendLayout();
            groupBoxResult_DMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_DMS).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_DMS);
            panel1.Controls.Add(buttonSave_DMS);
            panel1.Controls.Add(buttonDone_DMS);
            panel1.Controls.Add(buttonOpenFile_DMS);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 74);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_DMS
            // 
            buttonHelp_DMS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_DMS.Cursor = Cursors.Hand;
            buttonHelp_DMS.FlatStyle = FlatStyle.Flat;
            buttonHelp_DMS.Image = (Image)resources.GetObject("buttonHelp_DMS.Image");
            buttonHelp_DMS.Location = new Point(940, 3);
            buttonHelp_DMS.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_DMS.Name = "buttonHelp_DMS";
            buttonHelp_DMS.Size = new Size(88, 63);
            buttonHelp_DMS.TabIndex = 1;
            toolTip_DMS.SetToolTip(buttonHelp_DMS, "Сведения о программе");
            buttonHelp_DMS.UseVisualStyleBackColor = true;
            buttonHelp_DMS.Click += buttonHelp_DMS_Click;
            buttonHelp_DMS.MouseEnter += buttonHelp_DMS_MouseEnter;
            // 
            // buttonSave_DMS
            // 
            buttonSave_DMS.Cursor = Cursors.Hand;
            buttonSave_DMS.Enabled = false;
            buttonSave_DMS.FlatStyle = FlatStyle.Flat;
            buttonSave_DMS.Image = (Image)resources.GetObject("buttonSave_DMS.Image");
            buttonSave_DMS.Location = new Point(192, 3);
            buttonSave_DMS.Margin = new Padding(4, 3, 4, 3);
            buttonSave_DMS.Name = "buttonSave_DMS";
            buttonSave_DMS.Size = new Size(88, 63);
            buttonSave_DMS.TabIndex = 1;
            toolTip_DMS.SetToolTip(buttonSave_DMS, "Сохранить файл");
            buttonSave_DMS.UseVisualStyleBackColor = true;
            buttonSave_DMS.Click += buttonSave_DMS_Click;
            buttonSave_DMS.MouseEnter += buttonSave_DMS_MouseEnter;
            // 
            // buttonDone_DMS
            // 
            buttonDone_DMS.Cursor = Cursors.Hand;
            buttonDone_DMS.Enabled = false;
            buttonDone_DMS.FlatStyle = FlatStyle.Flat;
            buttonDone_DMS.Image = (Image)resources.GetObject("buttonDone_DMS.Image");
            buttonDone_DMS.Location = new Point(98, 3);
            buttonDone_DMS.Margin = new Padding(4, 3, 4, 3);
            buttonDone_DMS.Name = "buttonDone_DMS";
            buttonDone_DMS.Size = new Size(88, 63);
            buttonDone_DMS.TabIndex = 1;
            toolTip_DMS.SetToolTip(buttonDone_DMS, "Заменяет все значение в 9 столбце на 11\r\n");
            buttonDone_DMS.UseVisualStyleBackColor = true;
            buttonDone_DMS.Click += buttonDone_DMS_Click;
            buttonDone_DMS.MouseEnter += buttonDone_DMS_MouseEnter;
            // 
            // buttonOpenFile_DMS
            // 
            buttonOpenFile_DMS.Cursor = Cursors.Hand;
            buttonOpenFile_DMS.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_DMS.Image = (Image)resources.GetObject("buttonOpenFile_DMS.Image");
            buttonOpenFile_DMS.Location = new Point(4, 3);
            buttonOpenFile_DMS.Margin = new Padding(4, 3, 4, 3);
            buttonOpenFile_DMS.Name = "buttonOpenFile_DMS";
            buttonOpenFile_DMS.Size = new Size(88, 63);
            buttonOpenFile_DMS.TabIndex = 1;
            toolTip_DMS.SetToolTip(buttonOpenFile_DMS, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_DMS.UseVisualStyleBackColor = true;
            buttonOpenFile_DMS.Click += buttonOpenFile_DMS_Click;
            buttonOpenFile_DMS.MouseEnter += buttonOpenFile_DMS_MouseEnter;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTask_DMS);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 74);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1031, 98);
            panel2.TabIndex = 0;
            // 
            // groupBoxTask_DMS
            // 
            groupBoxTask_DMS.Controls.Add(textBoxTask_DMS);
            groupBoxTask_DMS.Dock = DockStyle.Fill;
            groupBoxTask_DMS.Location = new Point(0, 0);
            groupBoxTask_DMS.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_DMS.Name = "groupBoxTask_DMS";
            groupBoxTask_DMS.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_DMS.Size = new Size(1031, 98);
            groupBoxTask_DMS.TabIndex = 0;
            groupBoxTask_DMS.TabStop = false;
            groupBoxTask_DMS.Text = "Условие:";
            // 
            // textBoxTask_DMS
            // 
            textBoxTask_DMS.Dock = DockStyle.Fill;
            textBoxTask_DMS.Location = new Point(4, 19);
            textBoxTask_DMS.Margin = new Padding(4, 3, 4, 3);
            textBoxTask_DMS.Multiline = true;
            textBoxTask_DMS.Name = "textBoxTask_DMS";
            textBoxTask_DMS.ReadOnly = true;
            textBoxTask_DMS.Size = new Size(1023, 76);
            textBoxTask_DMS.TabIndex = 0;
            textBoxTask_DMS.Text = resources.GetString("textBoxTask_DMS.Text");
            textBoxTask_DMS.TextChanged += textBoxTask_DMS_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxInput_DMS);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 172);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(502, 418);
            panel3.TabIndex = 0;
            // 
            // groupBoxInput_DMS
            // 
            groupBoxInput_DMS.Controls.Add(dataGridViewInMatrix_DMS);
            groupBoxInput_DMS.Dock = DockStyle.Fill;
            groupBoxInput_DMS.Location = new Point(0, 0);
            groupBoxInput_DMS.Margin = new Padding(4, 3, 4, 3);
            groupBoxInput_DMS.Name = "groupBoxInput_DMS";
            groupBoxInput_DMS.Padding = new Padding(4, 3, 4, 3);
            groupBoxInput_DMS.Size = new Size(502, 418);
            groupBoxInput_DMS.TabIndex = 0;
            groupBoxInput_DMS.TabStop = false;
            groupBoxInput_DMS.Text = "Ввод:";
            // 
            // dataGridViewInMatrix_DMS
            // 
            dataGridViewInMatrix_DMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_DMS.ColumnHeadersVisible = false;
            dataGridViewInMatrix_DMS.Dock = DockStyle.Fill;
            dataGridViewInMatrix_DMS.Location = new Point(4, 19);
            dataGridViewInMatrix_DMS.Margin = new Padding(4, 3, 4, 3);
            dataGridViewInMatrix_DMS.Name = "dataGridViewInMatrix_DMS";
            dataGridViewInMatrix_DMS.RowHeadersVisible = false;
            dataGridViewInMatrix_DMS.Size = new Size(494, 396);
            dataGridViewInMatrix_DMS.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxResult_DMS);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(502, 172);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(529, 418);
            panel4.TabIndex = 0;
            // 
            // groupBoxResult_DMS
            // 
            groupBoxResult_DMS.Controls.Add(dataGridViewOutMatrix_DMS);
            groupBoxResult_DMS.Dock = DockStyle.Fill;
            groupBoxResult_DMS.Location = new Point(0, 0);
            groupBoxResult_DMS.Margin = new Padding(4, 3, 4, 3);
            groupBoxResult_DMS.Name = "groupBoxResult_DMS";
            groupBoxResult_DMS.Padding = new Padding(4, 3, 4, 3);
            groupBoxResult_DMS.Size = new Size(529, 418);
            groupBoxResult_DMS.TabIndex = 0;
            groupBoxResult_DMS.TabStop = false;
            groupBoxResult_DMS.Text = "Вывод:";
            // 
            // dataGridViewOutMatrix_DMS
            // 
            dataGridViewOutMatrix_DMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_DMS.ColumnHeadersVisible = false;
            dataGridViewOutMatrix_DMS.Dock = DockStyle.Fill;
            dataGridViewOutMatrix_DMS.Location = new Point(4, 19);
            dataGridViewOutMatrix_DMS.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOutMatrix_DMS.Name = "dataGridViewOutMatrix_DMS";
            dataGridViewOutMatrix_DMS.RowHeadersVisible = false;
            dataGridViewOutMatrix_DMS.Size = new Size(521, 396);
            dataGridViewOutMatrix_DMS.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(502, 172);
            splitter1.Margin = new Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 418);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_DMS
            // 
            openFileDialogTask_DMS.FileName = "openFileDialog1";
            // 
            // toolTip_DMS
            // 
            toolTip_DMS.ToolTipIcon = ToolTipIcon.Info;
            toolTip_DMS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 590);
            Controls.Add(splitter1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1047, 629);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Дьяков М.С.";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxTask_DMS.ResumeLayout(false);
            groupBoxTask_DMS.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxInput_DMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_DMS).EndInit();
            panel4.ResumeLayout(false);
            groupBoxResult_DMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_DMS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxTask_DMS;
        private System.Windows.Forms.TextBox textBoxTask_DMS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxInput_DMS;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBoxResult_DMS;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonHelp_DMS;
        private System.Windows.Forms.Button buttonDone_DMS;
        private System.Windows.Forms.Button buttonOpenFile_DMS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DMS;
        private System.Windows.Forms.ToolTip toolTip_DMS;
        private System.Windows.Forms.Button buttonSave_DMS;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_DMS;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_DMS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
    }
}
