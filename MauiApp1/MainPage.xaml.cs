using System.Runtime.InteropServices;

namespace MauiApp1;

public partial class MainPage : ContentPage
{

    String defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

    public MainPage()
	{
		InitializeComponent();
        inputBox.Text = defaultPath;
    }

    void showListview(object sender, EventArgs args)
    {
        
    }

}



/*OLDOCDER
 * public Form1()
        {
            InitializeComponent();
            Location.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            NewGroup();
            LoadCss();

            using (var reader = new StringReader("^contentpage { background-color: blue; }"))
            {
                this.Resources.Add(StyleSheet.FromReader(reader));
            }
        }

        private void LoadCss()
        {
            //Location.BackColor = Color.Red;



            Log("Styles");

        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            NewGroup();
        }

        int locationLeft = 0;

        private void NewGroup()
        {
            ClearGroup();
            Log(Location.Text);


            string[] Locations = Location.Text.Split('\\');
            string result = "";

            ListView listview = new ListView();

            foreach (string location in Locations)
            {
                result += location + '\\';
                NewColumn(listview, result);
            }
        }


        private void ClearGroup()
        {
            Explorer.Controls.Clear();
        }

        private void NewColumn(ListView listview, String NewLocation)
        {
            
            //listview.Location = new Point(locationLeft, 10);
            listview.Size = new Size(500, 500);
            Explorer.Controls.Add(listview);
            
            
            listview.Columns.Add("Name", 100);
            
            string[] folders = Directory.GetDirectories(NewLocation);
            foreach (string folder in folders)
            {
                listview.Items.Add(new ListViewItem(new FileInfo(folder).Name));
            }

            string[] files = Directory.GetFiles(NewLocation);
            foreach (string file in files)
            {
                listview.Items.Add(new ListViewItem(new FileInfo(file).Name));
            }




            locationLeft += 250;
            
            //Log(newWindow.Left);
            //Log(NewLocation);
            //Log(locationLeft);

        }

        private void Log(object message)
        {
            try { 
                System.Console.WriteLine(message.ToString());
            } catch {
                System.Console.WriteLine(message);

            }
        }*/