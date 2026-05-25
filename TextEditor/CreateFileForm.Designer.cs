namespace TextEditor
{
    partial class CreateFileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFileForm));
            cancelBtn = new Button();
            saveBtn = new Button();
            newFileLbl = new Label();
            fileNameTxt = new TextBox();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(274, 76);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(86, 76);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // newFileLbl
            // 
            newFileLbl.AutoSize = true;
            newFileLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newFileLbl.Location = new Point(12, 41);
            newFileLbl.Name = "newFileLbl";
            newFileLbl.Size = new Size(68, 17);
            newFileLbl.TabIndex = 5;
            newFileLbl.Text = "File name";
            // 
            // fileNameTxt
            // 
            fileNameTxt.Location = new Point(86, 40);
            fileNameTxt.Name = "fileNameTxt";
            fileNameTxt.Size = new Size(263, 23);
            fileNameTxt.TabIndex = 4;
            fileNameTxt.Text = "New Text Document.txt";
            // 
            // CreateFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 111);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(newFileLbl);
            Controls.Add(fileNameTxt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateFileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateFile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button saveBtn;
        private Label newFileLbl;
        private TextBox fileNameTxt;
    }
}