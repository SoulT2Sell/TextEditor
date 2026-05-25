using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TextEditor
{
    public partial class CreateFileForm : Form
    {
        public string? FileName { get; private set; } = null;

        public CreateFileForm(string theme)
        {
            InitializeComponent();
            Applytheme(theme);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileNameTxt.Text))
            {
                MessageBox.Show("Enter File name (Optional: With extention)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileName = fileNameTxt.Text;

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

            fileNameTxt.BackColor = Color.FromArgb(30, 30, 30);
            fileNameTxt.ForeColor = Color.FromArgb(220, 220, 220);

            saveBtn.BackColor = Color.FromArgb(60, 60, 60);
            saveBtn.ForeColor = Color.White;

            cancelBtn.BackColor = Color.FromArgb(60, 60, 60);
            cancelBtn.ForeColor = Color.White;
        }

        private void LightTheme()
        {
            BackColor = Color.FromArgb(240, 240, 240);
            ForeColor = Color.FromArgb(50, 50, 50);

            fileNameTxt.BackColor = Color.White;
            fileNameTxt.ForeColor = Color.Black;


            saveBtn.BackColor = Color.FromArgb(240, 240, 240);
            saveBtn.ForeColor = Color.Black;

            cancelBtn.BackColor = Color.FromArgb(240, 240, 240);
            cancelBtn.ForeColor = Color.Black;
        }
    }
}
