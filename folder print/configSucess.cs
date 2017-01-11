using System;
using System.Windows.Forms;

namespace folder_print
{
    public partial class configSucessForm : Form
    {
        

        public configSucessForm()
        {
            InitializeComponent();
            MaximizeBox = MinimizeBox = false;
            messageLbl.Text = settings.messageText;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
