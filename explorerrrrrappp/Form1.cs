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

            LoadCss();
        }

        private void LoadCss()
        {
            Location.BackColor = Color.Red;

        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            NewGroup();
        }

        private void NewGroup()
        {
            ClearGroup();
            Log(Location.Text);


            string[] Locations = Location.Text.Split('\\');
            string result = "";
            foreach (string location in Locations)
            {
                result += location + '\\';
                NewColumn(new Uri(result));
            }
        }


        private void ClearGroup()
        {
            Explorer.Controls.Clear();
        }

        int locationLeft = 0;

        private void NewColumn(Uri NewLocation)
        {
            WebBrowser newWindow = new WebBrowser();
            newWindow.Url = NewLocation;



            newWindow.Width = 200;
            newWindow.Height = 400;// percentage
            newWindow.Left = locationLeft;

            Explorer.Controls.Add(newWindow);
            locationLeft += 200;

            Log(newWindow.Left);

            Log(NewLocation);
            Log(locationLeft);

        }

        private void Log(object message)
        {
            System.Console.WriteLine(message.ToString());
        }
    }
}
