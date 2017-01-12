using System;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.IO;

namespace folder_print
{
    public partial class settings : Form
    {
        public static string messageText = ""; //text to be displayed when save is pressed
        string config = ""; // all text to be written to settings.ini
        bool firstLine = true; // check if firstLine. If true Newline won't be inserted.

        public settings()
        {
            InitializeComponent();
        }        

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    folderBox.Text = folderDialog.SelectedPath;
                    startImmediatelyBox.Enabled = true;
                }
        }

        void addToFile (string setting)
        {
            if (firstLine)
            {
                config += setting;
                firstLine = false;
            }
            else config += Environment.NewLine + setting;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

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

            if (folderBox.Text != "") addToFile("path=" + folderBox.Text);            
            if (startMinimizedBox.Checked) addToFile("startMinimized = true");
            if (startImmediatelyBox.Checked) addToFile("startImmediately=true");
            if (pdfCheckBox.Checked) addToFile("pdf=true");
            if (docCheckBox.Checked) addToFile("doc=true");
            if (docxCheckBox.Checked) addToFile("docx=true");
            if (xlsCheckBox.Checked) addToFile("xls=true");
            if (xlsxCheckBox.Checked) addToFile("xlsx=true");
            if (rtfCheckBox.Checked) addToFile("rtf=true");

            try
            {
                System.IO.File.WriteAllText(Application.ExecutablePath.Substring(0, Application.ExecutablePath.Length - 17) + "\\settings.ini", config);
                messageText = "Configuration file saved successfully.";
            }
            catch(IOException) { messageText = "Configuration file cannot be created!"; }            

            configSucessForm csf = new configSucessForm();
            csf.Show();            
        }

        private void folderBox_TextChanged(object sender, EventArgs e)
        {
            startImmediatelyBox.Enabled = folderBox.Text.Length > 0 ? true : false;
        }
    }
}