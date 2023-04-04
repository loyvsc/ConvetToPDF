namespace wtpdf
{
    partial class Form1
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
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.StatusPanel = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SelectedFilesTextBox = new System.Windows.Forms.RichTextBox();
            this.ExportOption = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FileSelectButton.Location = new System.Drawing.Point(12, 12);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(111, 31);
            this.FileSelectButton.TabIndex = 0;
            this.FileSelectButton.Text = "Выбрать файлы";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.AllowDrop = true;
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ConvertButton.Location = new System.Drawing.Point(12, 88);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(111, 31);
            this.ConvertButton.TabIndex = 1;
            this.ConvertButton.Text = "Конвертировать";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // StatusPanel
            // 
            this.StatusPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.StatusPanel.Location = new System.Drawing.Point(0, 162);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(333, 22);
            this.StatusPanel.SizingGrip = false;
            this.StatusPanel.TabIndex = 2;
            this.StatusPanel.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // SelectedFilesTextBox
            // 
            this.SelectedFilesTextBox.Location = new System.Drawing.Point(129, 13);
            this.SelectedFilesTextBox.Name = "SelectedFilesTextBox";
            this.SelectedFilesTextBox.ReadOnly = true;
            this.SelectedFilesTextBox.Size = new System.Drawing.Size(195, 143);
            this.SelectedFilesTextBox.TabIndex = 3;
            this.SelectedFilesTextBox.Text = "";
            // 
            // ExportOption
            // 
            this.ExportOption.AutoSize = true;
            this.ExportOption.Location = new System.Drawing.Point(12, 126);
            this.ExportOption.Name = "ExportOption";
            this.ExportOption.Size = new System.Drawing.Size(102, 30);
            this.ExportOption.TabIndex = 4;
            this.ExportOption.Text = "Выбрать папку\r\nэкспорта";
            this.ExportOption.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.Location = new System.Drawing.Point(12, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выбрать папку с файлами";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 184);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExportOption);
            this.Controls.Add(this.SelectedFilesTextBox);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.FileSelectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word To PDF";
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileSelectButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.StatusStrip StatusPanel;
        private System.Windows.Forms.RichTextBox SelectedFilesTextBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox ExportOption;
        private System.Windows.Forms.Button button1;
    }
}

