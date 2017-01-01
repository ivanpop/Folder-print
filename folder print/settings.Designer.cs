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
            this.startWithWindowsBox = new System.Windows.Forms.CheckBox();
            this.startMinimizedBox = new System.Windows.Forms.CheckBox();
            this.predifinedFolderBox = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.folderBoxLabel = new System.Windows.Forms.Label();
            this.folderBox = new System.Windows.Forms.TextBox();
            this.startImmediatelyBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.confirmationLbl = new System.Windows.Forms.Label();
            this.predifinedFolderBox.SuspendLayout();
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
            this.predifinedFolderBox.Location = new System.Drawing.Point(13, 91);
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
            // 
            // startImmediatelyBox
            // 
            this.startImmediatelyBox.AutoSize = true;
            this.startImmediatelyBox.Location = new System.Drawing.Point(13, 59);
            this.startImmediatelyBox.Name = "startImmediatelyBox";
            this.startImmediatelyBox.Size = new System.Drawing.Size(160, 17);
            this.startImmediatelyBox.TabIndex = 3;
            this.startImmediatelyBox.Text = "Start the service immediately";
            this.startImmediatelyBox.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(105, 173);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // confirmationLbl
            // 
            this.confirmationLbl.AutoSize = true;
            this.confirmationLbl.Location = new System.Drawing.Point(62, 210);
            this.confirmationLbl.Name = "confirmationLbl";
            this.confirmationLbl.Size = new System.Drawing.Size(164, 13);
            this.confirmationLbl.TabIndex = 5;
            this.confirmationLbl.Text = "Configuration saved successfully!";
            this.confirmationLbl.Visible = false;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.confirmationLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.startImmediatelyBox);
            this.Controls.Add(this.predifinedFolderBox);
            this.Controls.Add(this.startMinimizedBox);
            this.Controls.Add(this.startWithWindowsBox);
            this.Name = "settings";
            this.Text = "settings";
            this.predifinedFolderBox.ResumeLayout(false);
            this.predifinedFolderBox.PerformLayout();
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
        private System.Windows.Forms.Label confirmationLbl;
    }
}