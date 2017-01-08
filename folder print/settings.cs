using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.IO;

namespace folder_print
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                    folderBox.Text = folderDialog.SelectedPath;
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
            
            if (startMinimizedBox.Checked)
            {
                if (firstLine)
                {
                    settings += "startMinimized = true";
                    firstLine = false;
                }
                else
                    settings += Environment.NewLine + "startMinimized = true";
            }

            System.IO.File.WriteAllText(Application.ExecutablePath.Substring(0, Application.ExecutablePath.Length - 17) + "\\settings.ini", settings);
        }
    }
}
