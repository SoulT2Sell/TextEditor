namespace TextEditor
{
    partial class CreateFolderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFolderForm));
            folderNameTxt = new TextBox();
            folderNameLbl = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // folderNameTxt
            // 
            folderNameTxt.Location = new Point(104, 42);
            folderNameTxt.Name = "folderNameTxt";
            folderNameTxt.Size = new Size(263, 23);
            folderNameTxt.TabIndex = 0;
            folderNameTxt.Text = "New Folder";
            // 
            // folderNameLbl
            // 
            folderNameLbl.AutoSize = true;
            folderNameLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            folderNameLbl.Location = new Point(12, 43);
            folderNameLbl.Name = "folderNameLbl";
            folderNameLbl.Size = new Size(85, 17);
            folderNameLbl.TabIndex = 1;
            folderNameLbl.Text = "Folder name";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(104, 86);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(292, 89);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // CreateFolderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 124);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(folderNameLbl);
            Controls.Add(folderNameTxt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(395, 163);
            MinimumSize = new Size(395, 163);
            Name = "CreateFolderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateFolder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox folderNameTxt;
        private Label folderNameLbl;
        private Button saveBtn;
        private Button cancelBtn;
    }
}