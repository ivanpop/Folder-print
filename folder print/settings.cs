using System;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.IO;

namespace folder_print
{
    public partial class settings : Form
    {
        public static string messageText = ""; //text to be displayed when save is pressed

        public settings()
        {
            InitializeComponent();
        }        

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    folderBox.Text = folderDialog.SelectedPath;
                    startImmediatelyBox.Enabled = true;
                }                    
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string settings = ""; // all text to be written to settings.ini
            bool firstLine = true; // check if firstLine. If true Newline won't be inserted.

            if (startWithWindowsBox.Checked)
            {
                var startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                var shell = new WshShell();
                var shortCutLinkFilePath = Path.Combine(startupFolderPath + "\\folder print.lnk");
                var windowsApplicationShortcut = (IWshShortcut)shell.CreateShortcut(shortCutLinkFilePath);
                windowsApplicationShortcut.WorkingDirectory = Application.StartupPath;
                windowsApplicationShortcut.TargetPath = Application.ExecutablePath;
                windowsApplicationShortcut.Save();
            }

            if (folderBox.Text != "")
            {
                if (firstLine)
                {
                    settings += "path=" + folderBox.Text;
                    firstLine = false;
                }
                else
                    settings += Environment.NewLine + "path=" + folderBox.Text;
            }
            
            if (startMinimizedBox.Checked)
            {
                if (firstLine)
                {
                    settings += "startMinimized=true";
                    firstLine = false;
                }
                else
                    settings += Environment.NewLine + "startMinimized=true";
            }

            if (startImmediatelyBox.Checked)
            {
                if (firstLine)
                {
                    settings += "startImmediately=true";
                    firstLine = false;
                }
                else
                    settings += Environment.NewLine + "startImmediately=true";
            }

            if (pdfCheckBox.Checked)
            {
                if (firstLine)
                {
                    settings += "pdf=true";
                    firstLine = false;
                }
                else
                    settings += Environment.NewLine + "pdf=true";
            }

            if (docCheckBox.Checked)
            {
                if (firstLine)
                {
                    settings += "doc=true";
                    firstLine = false;
                }
                else
                    settings += Environment.NewLine + "doc=true";
            }

            if (docxCheckBox.Checked)
            {
                if (firstLine)
                {
                    settings += "docx=true";
                    firstLine = false;
                }
                else
                    settings += Environment.NewLine + "docx=true";
            }

            if (xlsCheckBox.Checked)
            {
                if (firstLine)
                {
                    settings += "xls=true";
                    firstLine = false;
                }
                else
                    settings += Environment.NewLine + "xls=true";
            }

            if (xlsxCheckBox.Checked)
            {
                if (firstLine)
                {
                    settings += "xlsx=true";
                    firstLine = false;
                }
                else
                    settings += Environment.NewLine + "xlsx=true";
            }

            try
            {
                System.IO.File.WriteAllText(Application.ExecutablePath.Substring(0, Application.ExecutablePath.Length - 17) + "\\settings.ini", settings);
                messageText = "Configuration file saved successfully.";
            }
            catch(IOException)
            {
                messageText = "Configuration file cannot be created!";
            }            

            configSucessForm csf = new configSucessForm();
            csf.Show();            
        }

        private void folderBox_TextChanged(object sender, EventArgs e)
        {
            if (folderBox.Text.Length > 0)
                startImmediatelyBox.Enabled = true;
            else startImmediatelyBox.Enabled = false;
        }
    }
}