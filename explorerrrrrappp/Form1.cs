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
            Location.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            Folder.Url = new Uri(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));

        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {

            Folder.Url = new Uri(Location.Text);
        }
    }
}
