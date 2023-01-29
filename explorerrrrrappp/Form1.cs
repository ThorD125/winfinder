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

        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            newGroup();
        }

        private void newGroup()
        {

            Explorer.Controls.Clear();
            string[] Locations = Location.Text.Split('\\');
            string result = "";
            foreach (string location in Locations)
            {
                result += location + '\\';
                newColumn(new Uri(result));
            }
        }



        private void newColumn(Uri NewLocation)
        {
            WebBrowser newWindow = new WebBrowser();
            newWindow.Url = NewLocation;
            Explorer.Controls.Add(newWindow);


            System.Console.WriteLine(NewLocation.ToString());
        }
    }
}
