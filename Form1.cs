using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace wtpdf
{
    public partial class Form1 : Form
    {
        private List<string> selectedFiles;
        private string exportPath;

        public Form1()
        {
            InitializeComponent();
            selectedFiles = new List<string>(16);
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog fileDialog = new OpenFileDialog()
                {
                    Multiselect = true,
                    Title = "Выберите нужные Word файлы",
                    Filter = "Файд Word 2007 (*.docx)|*.docx"
                })
                {
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedFiles.AddRange(fileDialog.FileNames);
                        SelectedFilesTextBox.Text = string.Join("\n", selectedFiles);
                        StatusPanel.Items[0].Text = "Файлы выбраны";
                    }
                }
            }
            catch (Exception ex)
            {
                StatusPanel.Items[0].Text = "Ошибка: " + ex.Message;
                selectedFiles.Clear();
                SelectedFilesTextBox.Text = "";
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedFiles.Count == 0)
                {
                    throw new Exception("Ни один файл не выбран");
                }
                else
                {
                    if (ExportOption.Checked == true)
                    {
                        using (FolderBrowserDialog FolderSelectel = new FolderBrowserDialog() { Description = "Выбор папки экспорта"})
                        {
                            DialogResult result = FolderSelectel.ShowDialog();
                            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderSelectel.SelectedPath))
                            {
                                exportPath = FolderSelectel.SelectedPath;
                            }
                            else return;
                        }
                        using (ToPDF converter = new ToPDF())
                        {
                            for (int i = 0; i < selectedFiles.Count; i++)
                            {
                                converter.WordToPDF(selectedFiles[i], Path.Combine(exportPath, Path.GetFileName(selectedFiles[i])).Replace(".docx", ".pdf"));
                            }
                        }
                    }
                    else
                    {
                        using (ToPDF converter = new ToPDF())
                        {
                            for (int i = 0; i < selectedFiles.Count; i++)
                            {
                                converter.WordToPDF(selectedFiles[i], selectedFiles[i].Replace(".docx", ".pdf"));
                            }
                        }
                    }
                }
                StatusPanel.Items[0].Text = "Готово!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                selectedFiles.Clear();
                SelectedFilesTextBox.Text = "";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog FolderSelectel = new FolderBrowserDialog())
                {
                    DialogResult result = FolderSelectel.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderSelectel.SelectedPath))
                    {
                        string[] bufFiles = Directory.GetFiles(FolderSelectel.SelectedPath);
                        for (int i = 0; i < bufFiles.Length; i++)
                        {
                            if (bufFiles[i].Contains(".docx"))
                            {
                                selectedFiles.Add(bufFiles[i]);
                            }
                        }
                    }
                }
            }
            finally
            {
                SelectedFilesTextBox.Text = string.Join("\n", selectedFiles);
            }
        }
    }
}
