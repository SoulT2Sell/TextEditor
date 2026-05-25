using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class CreateFolderForm : Form
    {
        public string? FolderName { get; private set; } = null;
     
        public CreateFolderForm(string theme)
        {
            InitializeComponent();
            Applytheme(theme);  
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(folderNameTxt.Text))
            {
                MessageBox.Show("Enter folder name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            FolderName = folderNameTxt.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Applytheme(string theme)
        {
            switch (theme)
            {
                case "Light":
                    LightTheme();
                    break;
                case "Dark":
                    DarkTheme();
                    break;
                default:
                    break;
            }
        }

        private void DarkTheme()
        {
            BackColor = Color.FromArgb(30, 30, 30);
            ForeColor = Color.FromArgb(220, 220, 220);

            folderNameTxt.BackColor = Color.FromArgb(30, 30, 30);
            folderNameTxt.ForeColor = Color.FromArgb(220, 220, 220);

            saveBtn.BackColor = Color.FromArgb(60, 60, 60);
            saveBtn.ForeColor = Color.White;

            cancelBtn.BackColor = Color.FromArgb(60, 60, 60);
            cancelBtn.ForeColor = Color.White;
        }

        private void LightTheme()
        {
            BackColor = Color.FromArgb(240, 240, 240);
            ForeColor = Color.FromArgb(50, 50, 50);

            folderNameTxt.BackColor = Color.White;
            folderNameTxt.ForeColor = Color.Black;


            saveBtn.BackColor = Color.FromArgb(240, 240, 240);
            saveBtn.ForeColor = Color.Black;

            cancelBtn.BackColor = Color.FromArgb(240, 240, 240);
            cancelBtn.ForeColor = Color.Black;
        }
    }
}
