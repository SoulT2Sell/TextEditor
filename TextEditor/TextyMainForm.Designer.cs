namespace TextEditor
{
    partial class TextyMainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextyMainForm));
            menuStrip = new MenuStrip();
            menuStripFile = new ToolStripMenuItem();
            menuStripNewFile = new ToolStripMenuItem();
            menuStripOpenFile = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuStripOpenFolder = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menuStripSaveFile = new ToolStripMenuItem();
            menuStripSaveAsFile = new ToolStripMenuItem();
            menuStripTools = new ToolStripMenuItem();
            menuStripCut = new ToolStripMenuItem();
            menuStripCopy = new ToolStripMenuItem();
            menuStripPaste = new ToolStripMenuItem();
            menuStripSelectAll = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuStripThemes = new ToolStripMenuItem();
            menuStripThemeLight = new ToolStripMenuItem();
            menuStripThemeDark = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            textBox = new RichTextBox();
            listBox = new ListBox();
            statusStrip = new StatusStrip();
            progressBar = new ToolStripProgressBar();
            progressBarLabel = new ToolStripStatusLabel();
            filePathLabel = new ToolStripStatusLabel();
            spliterContainer = new SplitContainer();
            openFolderBtn = new Button();
            backBtn = new Button();
            directoryPathLabel = new Label();
            goForwardBtn = new Button();
            newFileBtn = new Button();
            newFolderBtn = new Button();
            foldersLabel = new Label();
            label1 = new Label();
            saveFileDialog = new SaveFileDialog();
            toolTip = new ToolTip(components);
            folderBrowserDialog = new FolderBrowserDialog();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spliterContainer).BeginInit();
            spliterContainer.Panel1.SuspendLayout();
            spliterContainer.Panel2.SuspendLayout();
            spliterContainer.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ScrollBar;
            menuStrip.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuStripFile, menuStripTools });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1004, 25);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menuStripFile
            // 
            menuStripFile.DropDownItems.AddRange(new ToolStripItem[] { menuStripNewFile, menuStripOpenFile, toolStripSeparator1, menuStripOpenFolder, toolStripSeparator3, menuStripSaveFile, menuStripSaveAsFile });
            menuStripFile.Image = (Image)resources.GetObject("menuStripFile.Image");
            menuStripFile.Name = "menuStripFile";
            menuStripFile.Size = new Size(56, 21);
            menuStripFile.Text = "File";
            menuStripFile.ToolTipText = "Open or save your files";
            // 
            // menuStripNewFile
            // 
            menuStripNewFile.Image = (Image)resources.GetObject("menuStripNewFile.Image");
            menuStripNewFile.Name = "menuStripNewFile";
            menuStripNewFile.Size = new Size(180, 22);
            menuStripNewFile.Text = "New file";
            menuStripNewFile.ToolTipText = "Create a new file ";
            menuStripNewFile.Click += newFile_Click;
            // 
            // menuStripOpenFile
            // 
            menuStripOpenFile.Image = (Image)resources.GetObject("menuStripOpenFile.Image");
            menuStripOpenFile.Name = "menuStripOpenFile";
            menuStripOpenFile.Size = new Size(180, 22);
            menuStripOpenFile.Text = "Open file";
            menuStripOpenFile.ToolTipText = "Open an existing file";
            menuStripOpenFile.Click += openFile_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // menuStripOpenFolder
            // 
            menuStripOpenFolder.Image = (Image)resources.GetObject("menuStripOpenFolder.Image");
            menuStripOpenFolder.Name = "menuStripOpenFolder";
            menuStripOpenFolder.Size = new Size(180, 22);
            menuStripOpenFolder.Text = "Open folder";
            menuStripOpenFolder.Click += menuStripOpenFolder_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(177, 6);
            // 
            // menuStripSaveFile
            // 
            menuStripSaveFile.Image = (Image)resources.GetObject("menuStripSaveFile.Image");
            menuStripSaveFile.Name = "menuStripSaveFile";
            menuStripSaveFile.Size = new Size(180, 22);
            menuStripSaveFile.Text = "Save";
            menuStripSaveFile.ToolTipText = "Save your file";
            menuStripSaveFile.Click += saveFile_Click;
            // 
            // menuStripSaveAsFile
            // 
            menuStripSaveAsFile.Image = (Image)resources.GetObject("menuStripSaveAsFile.Image");
            menuStripSaveAsFile.Name = "menuStripSaveAsFile";
            menuStripSaveAsFile.Size = new Size(180, 22);
            menuStripSaveAsFile.Text = "SaveAs";
            menuStripSaveAsFile.ToolTipText = "Save your file with select path";
            menuStripSaveAsFile.Click += saveAsFile_Click;
            // 
            // menuStripTools
            // 
            menuStripTools.DropDownItems.AddRange(new ToolStripItem[] { menuStripCut, menuStripCopy, menuStripPaste, menuStripSelectAll, toolStripSeparator2, menuStripThemes });
            menuStripTools.Image = (Image)resources.GetObject("menuStripTools.Image");
            menuStripTools.Name = "menuStripTools";
            menuStripTools.Size = new Size(67, 21);
            menuStripTools.Text = "Tools";
            menuStripTools.ToolTipText = "There is tools for editing your text and editor";
            // 
            // menuStripCut
            // 
            menuStripCut.Image = (Image)resources.GetObject("menuStripCut.Image");
            menuStripCut.Name = "menuStripCut";
            menuStripCut.Size = new Size(180, 22);
            menuStripCut.Text = "Cut";
            menuStripCut.ToolTipText = "Cut the selected text";
            menuStripCut.Click += cut_Click;
            // 
            // menuStripCopy
            // 
            menuStripCopy.Image = (Image)resources.GetObject("menuStripCopy.Image");
            menuStripCopy.Name = "menuStripCopy";
            menuStripCopy.Size = new Size(180, 22);
            menuStripCopy.Text = "Copy";
            menuStripCopy.ToolTipText = "Copy the selected text";
            menuStripCopy.Click += copy_Click;
            // 
            // menuStripPaste
            // 
            menuStripPaste.Image = (Image)resources.GetObject("menuStripPaste.Image");
            menuStripPaste.Name = "menuStripPaste";
            menuStripPaste.Size = new Size(180, 22);
            menuStripPaste.Text = "Paste";
            menuStripPaste.ToolTipText = "Paste text";
            menuStripPaste.Click += paste_Click;
            // 
            // menuStripSelectAll
            // 
            menuStripSelectAll.Name = "menuStripSelectAll";
            menuStripSelectAll.Size = new Size(180, 22);
            menuStripSelectAll.Text = "Select all";
            menuStripSelectAll.ToolTipText = "Select all of the text";
            menuStripSelectAll.Click += selectAll_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // menuStripThemes
            // 
            menuStripThemes.DropDownItems.AddRange(new ToolStripItem[] { menuStripThemeLight, menuStripThemeDark });
            menuStripThemes.Image = (Image)resources.GetObject("menuStripThemes.Image");
            menuStripThemes.Name = "menuStripThemes";
            menuStripThemes.Size = new Size(180, 22);
            menuStripThemes.Text = "Themes";
            menuStripThemes.ToolTipText = "Themes of the editor";
            // 
            // menuStripThemeLight
            // 
            menuStripThemeLight.Name = "menuStripThemeLight";
            menuStripThemeLight.Size = new Size(180, 22);
            menuStripThemeLight.Text = "Light";
            menuStripThemeLight.ToolTipText = "Lite theme";
            menuStripThemeLight.Click += toolStripThemeLight_Click;
            // 
            // menuStripThemeDark
            // 
            menuStripThemeDark.Name = "menuStripThemeDark";
            menuStripThemeDark.Size = new Size(180, 22);
            menuStripThemeDark.Text = "Dark";
            menuStripThemeDark.ToolTipText = "Dark theme";
            menuStripThemeDark.Click += toolStripThemeDark_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.Filter = "All types| *.*| Text Document| *.txt| Python script| *.py| Cpp file| *.cpp";
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.Location = new Point(0, 22);
            textBox.Margin = new Padding(10);
            textBox.Name = "textBox";
            textBox.Size = new Size(793, 435);
            textBox.TabIndex = 1;
            textBox.Text = "";
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(8, 75);
            listBox.Name = "listBox";
            listBox.Size = new Size(163, 379);
            listBox.TabIndex = 2;
            listBox.DoubleClick += listBox_DoubleClick;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { progressBar, progressBarLabel, filePathLabel });
            statusStrip.Location = new Point(0, 492);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1004, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip";
            // 
            // progressBar
            // 
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(110, 16);
            // 
            // progressBarLabel
            // 
            progressBarLabel.Name = "progressBarLabel";
            progressBarLabel.Size = new Size(54, 17);
            progressBarLabel.Text = "Nothing!";
            // 
            // filePathLabel
            // 
            filePathLabel.Name = "filePathLabel";
            filePathLabel.Size = new Size(66, 17);
            filePathLabel.Text = "Select a file";
            // 
            // spliterContainer
            // 
            spliterContainer.Dock = DockStyle.Fill;
            spliterContainer.Location = new Point(0, 25);
            spliterContainer.Name = "spliterContainer";
            // 
            // spliterContainer.Panel1
            // 
            spliterContainer.Panel1.Controls.Add(openFolderBtn);
            spliterContainer.Panel1.Controls.Add(backBtn);
            spliterContainer.Panel1.Controls.Add(directoryPathLabel);
            spliterContainer.Panel1.Controls.Add(goForwardBtn);
            spliterContainer.Panel1.Controls.Add(newFileBtn);
            spliterContainer.Panel1.Controls.Add(newFolderBtn);
            spliterContainer.Panel1.Controls.Add(foldersLabel);
            spliterContainer.Panel1.Controls.Add(listBox);
            // 
            // spliterContainer.Panel2
            // 
            spliterContainer.Panel2.Controls.Add(label1);
            spliterContainer.Panel2.Controls.Add(textBox);
            spliterContainer.Size = new Size(1004, 467);
            spliterContainer.SplitterDistance = 171;
            spliterContainer.SplitterWidth = 6;
            spliterContainer.TabIndex = 4;
            // 
            // openFolderBtn
            // 
            openFolderBtn.Cursor = Cursors.Hand;
            openFolderBtn.Image = (Image)resources.GetObject("openFolderBtn.Image");
            openFolderBtn.Location = new Point(8, 26);
            openFolderBtn.Name = "openFolderBtn";
            openFolderBtn.Size = new Size(25, 23);
            openFolderBtn.TabIndex = 3;
            toolTip.SetToolTip(openFolderBtn, "Open an directory");
            openFolderBtn.UseVisualStyleBackColor = true;
            openFolderBtn.Click += openFolderBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Cursor = Cursors.Hand;
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(39, 26);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(25, 23);
            backBtn.TabIndex = 6;
            toolTip.SetToolTip(backBtn, "Go one directory back");
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // directoryPathLabel
            // 
            directoryPathLabel.AutoSize = true;
            directoryPathLabel.Location = new Point(8, 57);
            directoryPathLabel.Name = "directoryPathLabel";
            directoryPathLabel.Size = new Size(105, 15);
            directoryPathLabel.TabIndex = 8;
            directoryPathLabel.Text = "Open An Directory";
            // 
            // goForwardBtn
            // 
            goForwardBtn.Cursor = Cursors.Hand;
            goForwardBtn.FlatAppearance.BorderSize = 0;
            goForwardBtn.Image = (Image)resources.GetObject("goForwardBtn.Image");
            goForwardBtn.Location = new Point(70, 26);
            goForwardBtn.Name = "goForwardBtn";
            goForwardBtn.Size = new Size(25, 23);
            goForwardBtn.TabIndex = 7;
            toolTip.SetToolTip(goForwardBtn, "Go one directory forward");
            goForwardBtn.UseVisualStyleBackColor = true;
            goForwardBtn.Click += goForwardBtn_Click;
            // 
            // newFileBtn
            // 
            newFileBtn.Cursor = Cursors.Hand;
            newFileBtn.Image = (Image)resources.GetObject("newFileBtn.Image");
            newFileBtn.Location = new Point(132, 26);
            newFileBtn.Name = "newFileBtn";
            newFileBtn.Size = new Size(25, 24);
            newFileBtn.TabIndex = 5;
            toolTip.SetToolTip(newFileBtn, "Make new file in current directory");
            newFileBtn.UseVisualStyleBackColor = true;
            newFileBtn.Click += newFileBtn_Click;
            // 
            // newFolderBtn
            // 
            newFolderBtn.Cursor = Cursors.Hand;
            newFolderBtn.Image = (Image)resources.GetObject("newFolderBtn.Image");
            newFolderBtn.Location = new Point(101, 26);
            newFolderBtn.Name = "newFolderBtn";
            newFolderBtn.Size = new Size(25, 23);
            newFolderBtn.TabIndex = 4;
            toolTip.SetToolTip(newFolderBtn, "Make new folder in current directory");
            newFolderBtn.UseVisualStyleBackColor = true;
            newFolderBtn.Click += newFolderBtn_Click;
            // 
            // foldersLabel
            // 
            foldersLabel.AutoSize = true;
            foldersLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foldersLabel.Location = new Point(28, 3);
            foldersLabel.Name = "foldersLabel";
            foldersLabel.Size = new Size(102, 17);
            foldersLabel.TabIndex = 2;
            foldersLabel.Text = "Folder Explorer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 2;
            label1.Text = "Editor";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "All types| *.*| Text Document| *.txt| Python script| *.py| Cpp file| *.cpp";
            // 
            // TextyMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 514);
            Controls.Add(spliterContainer);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Name = "TextyMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Texty";
            Load += TextyMainForm_Load;
            KeyDown += TextyMainForm_KeyDown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            spliterContainer.Panel1.ResumeLayout(false);
            spliterContainer.Panel1.PerformLayout();
            spliterContainer.Panel2.ResumeLayout(false);
            spliterContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spliterContainer).EndInit();
            spliterContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuStripFile;
        private ToolStripMenuItem menuStripNewFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuStripOpenFile;
        private ToolStripMenuItem menuStripSaveFile;
        private ToolStripMenuItem menuStripSaveAsFile;
        private OpenFileDialog openFileDialog;
        private RichTextBox textBox;
        private StatusStrip statusStrip;
        private ToolStripMenuItem menuStripTools;
        private ToolStripMenuItem menuStripCut;
        private ToolStripMenuItem menuStripCopy;
        private ToolStripMenuItem menuStripPaste;
        private ToolStripMenuItem menuStripSelectAll;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menuStripThemes;
        private ToolStripMenuItem menuStripThemeLight;
        private ToolStripMenuItem menuStripThemeDark;
        private SplitContainer spliterContainer;
        private SaveFileDialog saveFileDialog;
        private ToolStripProgressBar progressBar;
        private ToolStripStatusLabel progressBarLabel;
        private ToolTip toolTip;
        private Label foldersLabel;
        private Label label1;
        private Button openFolderBtn;
        private Button newFileBtn;
        private FolderBrowserDialog folderBrowserDialog;
        private ToolStripStatusLabel filePathLabel;
        private Label directoryPathLabel;
        private ListBox listBox;
        private ToolStripMenuItem menuStripOpenFolder;
        private ToolStripSeparator toolStripSeparator3;
        private Button backBtn;
        private Button goForwardBtn;
        private Button newFolderBtn;
    }
}
