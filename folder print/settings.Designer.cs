namespace folder_print
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.startWithWindowsBox = new System.Windows.Forms.CheckBox();
            this.startMinimizedBox = new System.Windows.Forms.CheckBox();
            this.predifinedFolderBox = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.folderBoxLabel = new System.Windows.Forms.Label();
            this.folderBox = new System.Windows.Forms.TextBox();
            this.startImmediatelyBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.extensionsBox = new System.Windows.Forms.GroupBox();
            this.xlsxCheckBox = new System.Windows.Forms.CheckBox();
            this.xlsCheckBox = new System.Windows.Forms.CheckBox();
            this.docxCheckBox = new System.Windows.Forms.CheckBox();
            this.docCheckBox = new System.Windows.Forms.CheckBox();
            this.pdfCheckBox = new System.Windows.Forms.CheckBox();
            this.predifinedFolderBox.SuspendLayout();
            this.extensionsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startWithWindowsBox
            // 
            this.startWithWindowsBox.AutoSize = true;
            this.startWithWindowsBox.Location = new System.Drawing.Point(13, 13);
            this.startWithWindowsBox.Name = "startWithWindowsBox";
            this.startWithWindowsBox.Size = new System.Drawing.Size(117, 17);
            this.startWithWindowsBox.TabIndex = 0;
            this.startWithWindowsBox.Text = "Start with Windows";
            this.startWithWindowsBox.UseVisualStyleBackColor = true;
            // 
            // startMinimizedBox
            // 
            this.startMinimizedBox.AutoSize = true;
            this.startMinimizedBox.Location = new System.Drawing.Point(13, 36);
            this.startMinimizedBox.Name = "startMinimizedBox";
            this.startMinimizedBox.Size = new System.Drawing.Size(96, 17);
            this.startMinimizedBox.TabIndex = 1;
            this.startMinimizedBox.Text = "Start minimized";
            this.startMinimizedBox.UseVisualStyleBackColor = true;
            // 
            // predifinedFolderBox
            // 
            this.predifinedFolderBox.Controls.Add(this.browseButton);
            this.predifinedFolderBox.Controls.Add(this.folderBoxLabel);
            this.predifinedFolderBox.Controls.Add(this.folderBox);
            this.predifinedFolderBox.Location = new System.Drawing.Point(13, 138);
            this.predifinedFolderBox.Name = "predifinedFolderBox";
            this.predifinedFolderBox.Size = new System.Drawing.Size(259, 76);
            this.predifinedFolderBox.TabIndex = 2;
            this.predifinedFolderBox.TabStop = false;
            this.predifinedFolderBox.Text = "Predefined folder";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(178, 16);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // folderBoxLabel
            // 
            this.folderBoxLabel.AutoSize = true;
            this.folderBoxLabel.Location = new System.Drawing.Point(6, 21);
            this.folderBoxLabel.Name = "folderBoxLabel";
            this.folderBoxLabel.Size = new System.Drawing.Size(69, 13);
            this.folderBoxLabel.TabIndex = 5;
            this.folderBoxLabel.Text = "Select folder:";
            // 
            // folderBox
            // 
            this.folderBox.Location = new System.Drawing.Point(6, 45);
            this.folderBox.Name = "folderBox";
            this.folderBox.Size = new System.Drawing.Size(247, 20);
            this.folderBox.TabIndex = 4;
            this.folderBox.TextChanged += new System.EventHandler(this.folderBox_TextChanged);
            // 
            // startImmediatelyBox
            // 
            this.startImmediatelyBox.AutoSize = true;
            this.startImmediatelyBox.Enabled = false;
            this.startImmediatelyBox.Location = new System.Drawing.Point(13, 59);
            this.startImmediatelyBox.Name = "startImmediatelyBox";
            this.startImmediatelyBox.Size = new System.Drawing.Size(160, 17);
            this.startImmediatelyBox.TabIndex = 3;
            this.startImmediatelyBox.Text = "Start the service immediately";
            this.startImmediatelyBox.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(105, 220);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // extensionsBox
            // 
            this.extensionsBox.Controls.Add(this.xlsxCheckBox);
            this.extensionsBox.Controls.Add(this.xlsCheckBox);
            this.extensionsBox.Controls.Add(this.docxCheckBox);
            this.extensionsBox.Controls.Add(this.docCheckBox);
            this.extensionsBox.Controls.Add(this.pdfCheckBox);
            this.extensionsBox.Location = new System.Drawing.Point(13, 83);
            this.extensionsBox.Name = "extensionsBox";
            this.extensionsBox.Size = new System.Drawing.Size(253, 49);
            this.extensionsBox.TabIndex = 6;
            this.extensionsBox.TabStop = false;
            this.extensionsBox.Text = "File extensions to monitor";
            // 
            // xlsxCheckBox
            // 
            this.xlsxCheckBox.AutoSize = true;
            this.xlsxCheckBox.Checked = true;
            this.xlsxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xlsxCheckBox.Location = new System.Drawing.Point(201, 19);
            this.xlsxCheckBox.Name = "xlsxCheckBox";
            this.xlsxCheckBox.Size = new System.Drawing.Size(43, 17);
            this.xlsxCheckBox.TabIndex = 11;
            this.xlsxCheckBox.Text = "xlsx";
            this.xlsxCheckBox.UseVisualStyleBackColor = true;
            // 
            // xlsCheckBox
            // 
            this.xlsCheckBox.AutoSize = true;
            this.xlsCheckBox.Checked = true;
            this.xlsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xlsCheckBox.Location = new System.Drawing.Point(157, 19);
            this.xlsCheckBox.Name = "xlsCheckBox";
            this.xlsCheckBox.Size = new System.Drawing.Size(38, 17);
            this.xlsCheckBox.TabIndex = 10;
            this.xlsCheckBox.Text = "xls";
            this.xlsCheckBox.UseVisualStyleBackColor = true;
            // 
            // docxCheckBox
            // 
            this.docxCheckBox.AutoSize = true;
            this.docxCheckBox.Checked = true;
            this.docxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.docxCheckBox.Location = new System.Drawing.Point(102, 19);
            this.docxCheckBox.Name = "docxCheckBox";
            this.docxCheckBox.Size = new System.Drawing.Size(49, 17);
            this.docxCheckBox.TabIndex = 9;
            this.docxCheckBox.Text = "docx";
            this.docxCheckBox.UseVisualStyleBackColor = true;
            // 
            // docCheckBox
            // 
            this.docCheckBox.AutoSize = true;
            this.docCheckBox.Checked = true;
            this.docCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.docCheckBox.Location = new System.Drawing.Point(52, 19);
            this.docCheckBox.Name = "docCheckBox";
            this.docCheckBox.Size = new System.Drawing.Size(44, 17);
            this.docCheckBox.TabIndex = 8;
            this.docCheckBox.Text = "doc";
            this.docCheckBox.UseVisualStyleBackColor = true;
            // 
            // pdfCheckBox
            // 
            this.pdfCheckBox.AutoSize = true;
            this.pdfCheckBox.Checked = true;
            this.pdfCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pdfCheckBox.Location = new System.Drawing.Point(6, 19);
            this.pdfCheckBox.Name = "pdfCheckBox";
            this.pdfCheckBox.Size = new System.Drawing.Size(41, 17);
            this.pdfCheckBox.TabIndex = 7;
            this.pdfCheckBox.Text = "pdf";
            this.pdfCheckBox.UseVisualStyleBackColor = true;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 253);
            this.Controls.Add(this.extensionsBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.startImmediatelyBox);
            this.Controls.Add(this.predifinedFolderBox);
            this.Controls.Add(this.startMinimizedBox);
            this.Controls.Add(this.startWithWindowsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.Text = "Settings";
            this.predifinedFolderBox.ResumeLayout(false);
            this.predifinedFolderBox.PerformLayout();
            this.extensionsBox.ResumeLayout(false);
            this.extensionsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startWithWindowsBox;
        private System.Windows.Forms.CheckBox startMinimizedBox;
        private System.Windows.Forms.GroupBox predifinedFolderBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label folderBoxLabel;
        private System.Windows.Forms.TextBox folderBox;
        private System.Windows.Forms.CheckBox startImmediatelyBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox extensionsBox;
        private System.Windows.Forms.CheckBox xlsxCheckBox;
        private System.Windows.Forms.CheckBox xlsCheckBox;
        private System.Windows.Forms.CheckBox docxCheckBox;
        private System.Windows.Forms.CheckBox docCheckBox;
        private System.Windows.Forms.CheckBox pdfCheckBox;
    }
}