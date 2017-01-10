namespace folder_print
{
    partial class createConfBtn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createConfBtn));
            this.serviceButton = new System.Windows.Forms.Button();
            this.folderBox = new System.Windows.Forms.TextBox();
            this.folderBoxLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.extensionsBox = new System.Windows.Forms.GroupBox();
            this.xlsxCheckBox = new System.Windows.Forms.CheckBox();
            this.xlsCheckBox = new System.Windows.Forms.CheckBox();
            this.docxCheckBox = new System.Windows.Forms.CheckBox();
            this.docCheckBox = new System.Windows.Forms.CheckBox();
            this.pdfCheckBox = new System.Windows.Forms.CheckBox();
            this.extensionsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceButton
            // 
            this.serviceButton.Enabled = false;
            this.serviceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceButton.Location = new System.Drawing.Point(12, 63);
            this.serviceButton.Name = "serviceButton";
            this.serviceButton.Size = new System.Drawing.Size(81, 57);
            this.serviceButton.TabIndex = 0;
            this.serviceButton.Text = "Start service";
            this.serviceButton.UseVisualStyleBackColor = true;
            this.serviceButton.Click += new System.EventHandler(this.serviceButton_Click);
            // 
            // folderBox
            // 
            this.folderBox.Location = new System.Drawing.Point(12, 37);
            this.folderBox.Name = "folderBox";
            this.folderBox.Size = new System.Drawing.Size(260, 20);
            this.folderBox.TabIndex = 1;
            this.folderBox.TextChanged += new System.EventHandler(this.folderBox_TextChanged);
            // 
            // folderBoxLabel
            // 
            this.folderBoxLabel.AutoSize = true;
            this.folderBoxLabel.Location = new System.Drawing.Point(12, 13);
            this.folderBoxLabel.Name = "folderBoxLabel";
            this.folderBoxLabel.Size = new System.Drawing.Size(69, 13);
            this.folderBoxLabel.TabIndex = 2;
            this.folderBoxLabel.Text = "Select folder:";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(197, 8);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(104, 73);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(85, 15);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Select a folder";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Double-click to show";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create configuration file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // extensionsBox
            // 
            this.extensionsBox.Controls.Add(this.xlsxCheckBox);
            this.extensionsBox.Controls.Add(this.xlsCheckBox);
            this.extensionsBox.Controls.Add(this.docxCheckBox);
            this.extensionsBox.Controls.Add(this.docCheckBox);
            this.extensionsBox.Controls.Add(this.pdfCheckBox);
            this.extensionsBox.Location = new System.Drawing.Point(12, 126);
            this.extensionsBox.Name = "extensionsBox";
            this.extensionsBox.Size = new System.Drawing.Size(253, 49);
            this.extensionsBox.TabIndex = 7;
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
            // createConfBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 211);
            this.Controls.Add(this.extensionsBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.folderBoxLabel);
            this.Controls.Add(this.folderBox);
            this.Controls.Add(this.serviceButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createConfBtn";
            this.Text = "Folder print";
            this.extensionsBox.ResumeLayout(false);
            this.extensionsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button serviceButton;
        private System.Windows.Forms.TextBox folderBox;
        private System.Windows.Forms.Label folderBoxLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox extensionsBox;
        private System.Windows.Forms.CheckBox xlsxCheckBox;
        private System.Windows.Forms.CheckBox xlsCheckBox;
        private System.Windows.Forms.CheckBox docxCheckBox;
        private System.Windows.Forms.CheckBox docCheckBox;
        private System.Windows.Forms.CheckBox pdfCheckBox;
    }
}

