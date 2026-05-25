namespace TextEditor
{
    public partial class TextyMainForm : Form
    {
        string filePath = string.Empty;
        string directoryPath = string.Empty;
        Stack<string> directoryHistoryStack = new Stack<string>();

        public TextyMainForm()
        {
            InitializeComponent();
        }

        #region Events
        private void TextyMainForm_Load(object sender, EventArgs e)
        {
            string currentTheme = Properties.Settings.Default.AppTheme;

            Applytheme(currentTheme);
        }

        private void TextyMainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                //Stops ding sound
                e.SuppressKeyPress = true;

                saveFile_Click(sender, e);
            }
        }

        private async void newFile_Click(object sender, EventArgs e)
        {
            await UpdateFilePathAndEditor(string.Empty);
            progressBar.Value = 0;
            progressBarLabel.ForeColor = Color.Black;
            progressBarLabel.Text = "Nothing!";
        }

        private async void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                await UpdateFilePathAndEditor(openFileDialog.FileName);
                await UpdateDirectoryPathAndListBox(Directory.GetParent(filePath).FullName);
            }
        }
        
        private void menuStripOpenFolder_Click(object sender, EventArgs e)
        {
            openFolderBtn_Click(sender, e);
        }

        private async void saveFile_Click(object sender, EventArgs e)
        {
            if (filePath == string.Empty)
            {
                await DialogSave();
            }
            else
            {
                await Save();
            }
        }

        private async void saveAsFile_Click(object sender, EventArgs e)
        {
            await DialogSave();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void toolStripThemeLight_Click(object sender, EventArgs e)
        {
            Applytheme("Light");
        }

        private void toolStripThemeDark_Click(object sender, EventArgs e)
        {
            Applytheme("Dark");
        }

        private async void openFolderBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                await UpdateDirectoryPathAndListBox(folderBrowserDialog.SelectedPath);
            }
        }

        private async void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null) return;

            string selectedItem = listBox.SelectedItem.ToString() ?? string.Empty;

            try
            {
                string fullPath = Path.Combine(directoryPath, selectedItem);

                if (File.Exists(fullPath))
                {
                    await UpdateFilePathAndEditor(fullPath);
                }
                else if (Directory.Exists(fullPath))
                {
                    await UpdateDirectoryPathAndListBox(fullPath);
                }
                else
                {
                    MessageBox.Show("Your file format not supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void backBtn_Click(object sender, EventArgs e)
        {
            if (directoryPath == String.Empty) return;

            string? parentPath = Directory.GetParent(directoryPath)?.FullName;

            if (parentPath == null) return;

            directoryHistoryStack.Push(directoryPath);
            await UpdateDirectoryPathAndListBox(parentPath);
        }

        private async void goForwardBtn_Click(object sender, EventArgs e)
        {
            if (directoryHistoryStack.Count == 0)
                return;

            string updateDirectory = directoryHistoryStack.Pop();
            await UpdateDirectoryPathAndListBox(updateDirectory);
        }

        private async void newFolderBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(directoryPath)) return;

            string? choosenName = null;
            string? folderName = null;
            using (CreateFolderForm createFolderForm = new CreateFolderForm(Properties.Settings.Default.AppTheme))
            {
                if (createFolderForm.ShowDialog() == DialogResult.OK)
                    choosenName = createFolderForm.FolderName;
            }

            if (choosenName == null) return;

            int folderCounter = 0;
            folderName = choosenName;
            while (Directory.Exists(Path.Combine(directoryPath, folderName)))
            {
                folderCounter++;
                folderName = $"{choosenName} ({folderCounter})";
            }

            if (folderCounter > 0)
            {
                var result = MessageBox.Show($"The folder named {choosenName} is already exists do want to save it as {folderName}?",
                                         "Dublicate folder name",
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel) return;
            }

            string finalFolderNameAndPath = Path.Combine(directoryPath, folderName);

            await Task.Run(() => Directory.CreateDirectory(finalFolderNameAndPath));
            await UpdateDirectoryPathAndListBox(directoryPath);
        }

        private async void newFileBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(directoryPath)) return;

            string? choosenName = null;
            string? fileFullName = null;

            using (var createFileForm = new CreateFileForm(Properties.Settings.Default.AppTheme))
            {
                if (createFileForm.ShowDialog() == DialogResult.OK)
                    choosenName = createFileForm.FileName;
            }

            if (choosenName == null) return;

            int fileCounter = 0;
            fileFullName = choosenName;

            while (File.Exists(Path.Combine(directoryPath, fileFullName)))
            {
                fileCounter++;
                string fileName = Path.GetFileNameWithoutExtension(choosenName);
                string fileExtention = Path.GetExtension(choosenName);
                fileFullName = $"{fileName} ({fileCounter}){fileExtention}";
            }

            if (fileCounter > 0)
            {
                var result = MessageBox.Show($"The file named {choosenName} is already exists do want to save it as {fileFullName}?",
                                         "Dublicate file name",
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel) return;
            }

            string finalFileNameAndPath = Path.Combine(directoryPath, fileFullName);

            await File.Create(finalFileNameAndPath).DisposeAsync();
            await UpdateDirectoryPathAndListBox(directoryPath);
        }
        #endregion

        #region Methods
        private async Task UpdateFilePathAndEditor(string insertedPath)
        {
            filePath = insertedPath;

            if (filePath == string.Empty)
            {
                filePathLabel.Text = "Save the file";
                textBox.Text = string.Empty;
                return;
            }

            filePathLabel.Text = filePath;
            textBox.Text = await File.ReadAllTextAsync(filePath);
        }

        private async Task UpdateDirectoryPathAndListBox(string insertedPath)
        {
            if (string.IsNullOrEmpty(insertedPath)) return;

            directoryPath = insertedPath;
            directoryPathLabel.Text = directoryPath;
            string[] directories = await Task.Run(() => Directory.GetDirectories(directoryPath));
            string[] files = await Task.Run(() => Directory.GetFiles(directoryPath));

            listBox.Items.Clear();
            foreach (string directory in directories)
            {
                listBox.Items.Add(Path.GetFileName(directory));
            }
            foreach (string file in files)
            {
                listBox.Items.Add(Path.GetFileName(file));
            }
        }

        private async Task DialogSave()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                await Save();
            }
        }

        private async Task Save()
        {
            try
            {
                progressBarLabel.Text = "Saving..";
                progressBar.Style = ProgressBarStyle.Marquee;
                await File.WriteAllTextAsync(filePath, textBox.Text);
                progressBar.Style = ProgressBarStyle.Blocks;
                progressBar.Value = 100;
                progressBarLabel.ForeColor = Color.Green;
                progressBarLabel.Text = "Done!";
            }
            catch
            {
                progressBar.Style = ProgressBarStyle.Blocks;
                progressBar.Value = 0;
                progressBarLabel.ForeColor = Color.Red;
                progressBarLabel.Text = "Failed!";
                MessageBox.Show("Your text file didnt save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    theme = "Unvalid";
                    break;
            }

            if (theme == "Unvalid") return;

            SaveTheme(theme);
        }

        private void SaveTheme(string theme)
        {
            Properties.Settings.Default.AppTheme = theme;

            Properties.Settings.Default.Save();
        }

        private void DarkTheme()
        {
            UncheckThemes();
            menuStripThemeDark.Checked = true;

            BackColor = Color.FromArgb(30, 30, 30);
            ForeColor = Color.FromArgb(220, 220, 220);

            spliterContainer.BackColor = Color.FromArgb(60, 60, 60);

            textBox.BackColor = Color.FromArgb(30, 30, 30);
            textBox.ForeColor = Color.FromArgb(220, 220, 220);

            listBox.BackColor = Color.FromArgb(30, 30, 30);
            listBox.ForeColor = Color.FromArgb(220, 220, 220);

            menuStrip.BackColor = Color.FromArgb(45, 45, 48);
            menuStrip.ForeColor = Color.FromArgb(220, 220, 220);

            statusStrip.BackColor = Color.FromArgb(0, 120, 215);
            statusStrip.ForeColor = Color.White;

            menuStripCut.BackColor = Color.FromArgb(45, 45, 48);
            menuStripCut.ForeColor = Color.FromArgb(220, 220, 220);

            menuStripCopy.BackColor = Color.FromArgb(45, 45, 48);
            menuStripCopy.ForeColor = Color.FromArgb(220, 220, 220);

            menuStripPaste.BackColor = Color.FromArgb(45, 45, 48);
            menuStripPaste.ForeColor = Color.FromArgb(220, 220, 220);

            menuStripSelectAll.BackColor = Color.FromArgb(45, 45, 48);
            menuStripSelectAll.ForeColor = Color.FromArgb(220, 220, 220);

            menuStripThemes.BackColor = Color.FromArgb(45, 45, 48);
            menuStripThemes.ForeColor = Color.FromArgb(220, 220, 220);

            menuStripThemeDark.BackColor = Color.FromArgb(45, 45, 48);
            menuStripThemeDark.ForeColor = Color.FromArgb(220, 220, 220);

            menuStripThemeLight.BackColor = Color.FromArgb(45, 45, 48);
            menuStripThemeLight.ForeColor = Color.FromArgb(220, 220, 220);

            menuStripNewFile.BackColor = Color.FromArgb(45, 45, 48);
            menuStripNewFile.ForeColor = Color.FromArgb(220, 220, 220);

            menuStripOpenFile.BackColor = Color.FromArgb(45, 45, 48);
            menuStripOpenFile.ForeColor = Color.FromArgb(220, 220, 220);

            menuStripOpenFolder.BackColor = Color.FromArgb(45, 45, 48);
            menuStripOpenFolder.ForeColor = Color.FromArgb(220, 220, 220);

            menuStripSaveFile.BackColor = Color.FromArgb(45, 45, 48);
            menuStripSaveFile.ForeColor = Color.FromArgb(220, 220, 220);

            menuStripSaveAsFile.BackColor = Color.FromArgb(45, 45, 48);
            menuStripSaveAsFile.ForeColor = Color.FromArgb(220, 220, 220);

            openFolderBtn.BackColor = Color.FromArgb(60, 60, 60);
            openFolderBtn.ForeColor = Color.White;

            backBtn.BackColor = Color.FromArgb(60, 60, 60);
            backBtn.ForeColor = Color.White;

            goForwardBtn.BackColor = Color.FromArgb(60, 60, 60);
            goForwardBtn.ForeColor = Color.White;

            newFolderBtn.BackColor = Color.FromArgb(60, 60, 60);
            newFolderBtn.ForeColor = Color.White;

            newFileBtn.BackColor = Color.FromArgb(60, 60, 60);
            newFileBtn.ForeColor = Color.White;
        }

        private void LightTheme()
        {
            UncheckThemes();
            menuStripThemeLight.Checked = true;

            BackColor = Color.FromArgb(240, 240, 240);
            ForeColor = Color.FromArgb(50, 50, 50);

            spliterContainer.BackColor = Color.FromArgb(200, 200, 200);

            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;

            listBox.BackColor = Color.White;
            listBox.ForeColor = Color.Black;

            menuStrip.BackColor = Color.FromArgb(248, 248, 248);
            menuStrip.ForeColor = Color.FromArgb(50, 50, 50);

            statusStrip.BackColor = Color.FromArgb(248, 248, 248);
            statusStrip.ForeColor = Color.FromArgb(80, 80, 80);

            menuStripCut.BackColor = Color.FromArgb(248, 248, 248);
            menuStripCut.ForeColor = Color.FromArgb(50, 50, 50);

            menuStripCopy.BackColor = Color.FromArgb(248, 248, 248);
            menuStripCopy.ForeColor = Color.FromArgb(50, 50, 50);

            menuStripPaste.BackColor = Color.FromArgb(248, 248, 248);
            menuStripPaste.ForeColor = Color.FromArgb(50, 50, 50);

            menuStripSelectAll.BackColor = Color.FromArgb(248, 248, 248);
            menuStripSelectAll.ForeColor = Color.FromArgb(50, 50, 50);

            menuStripThemes.BackColor = Color.FromArgb(248, 248, 248);
            menuStripThemes.ForeColor = Color.FromArgb(50, 50, 50);

            menuStripThemeDark.BackColor = Color.FromArgb(248, 248, 248);
            menuStripThemeDark.ForeColor = Color.FromArgb(50, 50, 50);

            menuStripThemeLight.BackColor = Color.FromArgb(248, 248, 248);
            menuStripThemeLight.ForeColor = Color.FromArgb(50, 50, 50);

            menuStripNewFile.BackColor = Color.FromArgb(248, 248, 248);
            menuStripNewFile.ForeColor = Color.FromArgb(50, 50, 50);

            menuStripOpenFile.BackColor = Color.FromArgb(248, 248, 248);
            menuStripOpenFile.ForeColor = Color.FromArgb(50, 50, 50);

            menuStripOpenFolder.BackColor = Color.FromArgb(248, 248, 248);
            menuStripOpenFolder.ForeColor = Color.FromArgb(50, 50, 50);

            menuStripSaveFile.BackColor = Color.FromArgb(248, 248, 248);
            menuStripSaveFile.ForeColor = Color.FromArgb(50, 50, 50);

            menuStripSaveAsFile.BackColor = Color.FromArgb(248, 248, 248);
            menuStripSaveAsFile.ForeColor = Color.FromArgb(50, 50, 50);

            openFolderBtn.BackColor = Color.FromArgb(240, 240, 240);
            openFolderBtn.ForeColor = Color.Black;

            backBtn.BackColor = Color.FromArgb(240, 240, 240);
            backBtn.ForeColor = Color.Black;

            goForwardBtn.BackColor = Color.FromArgb(240, 240, 240);
            goForwardBtn.ForeColor = Color.Black;

            newFolderBtn.BackColor = Color.FromArgb(240, 240, 240);
            newFolderBtn.ForeColor = Color.Black;

            newFileBtn.BackColor = Color.FromArgb(240, 240, 240);
            newFileBtn.ForeColor = Color.Black;
        }

        private void UncheckThemes()
        {
            menuStripThemeLight.Checked = false;
            menuStripThemeDark.Checked = false;
        }
        #endregion 

    }
}
