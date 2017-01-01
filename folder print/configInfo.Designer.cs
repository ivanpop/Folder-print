namespace folder_print
{
    partial class configInfo
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
            this.informationLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // informationLabel
            // 
            this.informationLabel.Location = new System.Drawing.Point(12, 9);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(260, 61);
            this.informationLabel.TabIndex = 0;
            this.informationLabel.Text = "The configuration file can be used to save all the settings you make to this prog" +
    "ram. You can set the program to start with Windows, to start minimized, to set t" +
    "he monitoring folder and etc.\r\n\r\n";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(100, 73);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // configInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 109);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.informationLabel);
            this.Name = "configInfo";
            this.Text = "Attention";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Button okBtn;
    }
}