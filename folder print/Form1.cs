using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folder_print
{
    public partial class Form1 : Form
    {
        bool serviceRunning = false;

        public Form1()
        {
            InitializeComponent();
            this.ShowInTaskbar = MaximizeBox = false;
        }

        protected override void OnResize(EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void serviceButton_Click(object sender, EventArgs e)
        {
            if (serviceButton.Text == "Start service")
            {                
                serviceButton.Text = "Stop service";
                infoLabel.Text = "Nothing to do";
                serviceRunning = true;
                runService();
                this.WindowState = FormWindowState.Minimized;
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

        private async void runService()
        {
            do
            {
                if (Directory.GetFiles(folderBox.Text).Length > 0)
                {
                    foreach (string str in Directory.GetFiles(folderBox.Text))
                    {
                        if (str.Substring(str.Length - 3) == "pdf")
                        {
                            ProcessStartInfo psi = new ProcessStartInfo(str);
                            FileInfo file = new FileInfo(str);
                            string[] strSubstr = str.Split('\\');
                            infoLabel.Text = "Processing: \n" + strSubstr[strSubstr.Length - 1];
                            psi.Verb = "print";
                            Process.Start(psi);
                            await Task.Delay(10000);
                            while (IsFileLocked(file))
                                Thread.Sleep(2000);
                            File.Delete(str);
                            infoLabel.Text = "Nothing to do";
                            if (serviceRunning == false)
                                break;
                        }                        
                    }
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
    }
}
