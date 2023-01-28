using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace explorerrrrrappp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description="Select path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK) { 
                    Folder.Url = new Uri(fbd.SelectedPath);
                    Location.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
