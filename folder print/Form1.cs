using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folder_print
{
    public partial class createConfBtn : Form
    {
        bool serviceRunning = false;

        public createConfBtn()
        {
            InitializeComponent();
            this.ShowInTaskbar = MaximizeBox = false;

            //read settings.ini
            if (File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "settings.ini"))
                foreach (string str in File.ReadLines(System.AppDomain.CurrentDomain.BaseDirectory + "settings.ini"))
                {
                    if (str.Contains("path="))
                    {
                        folderBox.Text = str.Substring(5);
                        serviceButton.Enabled = true;
                    }
                    if (str.Contains("startMinimized=true"))                    
                        this.WindowState = FormWindowState.Minimized;
                    
                }
        }

        protected override void OnResize(EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
                notifyIcon1.Visible = false;
        }

        private void serviceButton_Click(object sender, EventArgs e)
        {
            if (serviceButton.Text == "Start service")
            {   
                infoLabel.Text = "Nothing to do";
                serviceRunning = true;
                if (Directory.Exists(folderBox.Text))
                {
                    serviceButton.Text = "Stop service";
                    runService();
                }                    
                else
                    infoLabel.Text = "Folder doesn't exist.";                
            }
            else
            {
                serviceButton.Text = "Start service";
                infoLabel.Text = "Start the service";
                serviceRunning = false;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    folderBox.Text = folderDialog.SelectedPath;
                    serviceButton.Enabled = true;
                    infoLabel.Text = "Start the service";
                }
            }
        }

        private void print(string extension)
        {
            foreach (string str in Directory.GetFiles(folderBox.Text))
            {
                if (str.Substring(str.Length - 3) == extension)
                {
                    ProcessStartInfo psi = new ProcessStartInfo(str);
                    FileInfo file = new FileInfo(str);
                    string[] strSubstr = str.Split('\\');
                    infoLabel.Text = "Processing: \n" + strSubstr[strSubstr.Length - 1];
                    psi.Verb = "print";
                    Process.Start(psi);
                    Thread.Sleep(10000);
                    while (IsFileLocked(file)) Thread.Sleep(5000);                    
                    File.Delete(str);
                    infoLabel.Text = "Nothing to do";
                    if (serviceRunning == false)
                        break;                                       
                }
            }
        }

        private async void runService()
        {
            do
            {
                if (Directory.GetFiles(folderBox.Text).Length > 0)
                {
                    if (pdfCheckBox.Checked) print("pdf");
                    if (docCheckBox.Checked) print("doc");
                    if (docxCheckBox.Checked) print("ocx");
                    if (xlsCheckBox.Checked) print("xls");
                    if (xlsxCheckBox.Checked) print("lsx");
                }
                await Task.Delay(1000);
            } while (serviceRunning == true);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        protected virtual bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            configInfo config = new configInfo();
            config.Show();
        }
    }
}
