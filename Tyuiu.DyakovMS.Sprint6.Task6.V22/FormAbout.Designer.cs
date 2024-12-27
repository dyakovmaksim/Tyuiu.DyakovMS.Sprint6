namespace Tyuiu.DyakovMS.Sprint6.Task6.V22
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxAbout_DMS = new TextBox();
            buttonOk_DMS = new Button();
            SuspendLayout();
            // 
            // textBoxAbout_DMS
            // 
            textBoxAbout_DMS.Location = new Point(12, 12);
            textBoxAbout_DMS.Multiline = true;
            textBoxAbout_DMS.Name = "textBoxAbout_DMS";
            textBoxAbout_DMS.ReadOnly = true;
            textBoxAbout_DMS.Size = new Size(518, 216);
            textBoxAbout_DMS.TabIndex = 0;
            textBoxAbout_DMS.Text = resources.GetString("textBoxAbout_DMS.Text");
            // 
            // buttonOk_DMS
            // 
            buttonOk_DMS.Location = new Point(455, 165);
            buttonOk_DMS.Name = "buttonOk_DMS";
            buttonOk_DMS.Size = new Size(75, 23);
            buttonOk_DMS.TabIndex = 1;
            buttonOk_DMS.Text = "OK";
            buttonOk_DMS.UseVisualStyleBackColor = true;
            buttonOk_DMS.Click += buttonOk_DMS_CLick;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 200);
            Controls.Add(buttonOk_DMS);
            Controls.Add(textBoxAbout_DMS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAbout_DMS;
        private Button buttonOk_DMS;
    }
}