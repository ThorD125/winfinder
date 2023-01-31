using System.Runtime.InteropServices;
using Microsoft.Maui.Devices.Sensors;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    readonly String defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

    public MainPage()
	{
		InitializeComponent();
        inputBox.Text = defaultPath;
    }

    void showListview(object sender, EventArgs args)
    {
        ClearGroup();



        string[] Locations = inputBox.Text.Split('\\');
        string result = "";

        foreach (string location in Locations)
        {
            result += location + '\\';
            NewColumn(result);
        }

    }

    private void NewColumn(string NewLocation)
    {
        Log(NewLocation);


        

        //string[] folders = Directory.GetDirectories(NewLocation);
        ////foreach (string folder in folders)
        ////{
        ////    explorerTable.Items.Add(new ListViewItem(new FileInfo(folder).Name));
        ////}

        //string[] files = Directory.GetFiles(NewLocation);
        ////foreach (string file in files)
        ////{
        ////    explorerTable.Items.Add(new ListViewItem(new FileInfo(file).Name));
        ////}

        //String[] foldersandfiles = folders.Union(files).ToArray();

        ListView listView = new ListView();
        listView.SetBinding(ItemsView.ItemsSourceProperty, "foldersandfiles");
        divLists.Add(listView);
    }


    private void ClearGroup()
    {
        Log("explorerTable.Clear");
    }

    private void Log(object message)
    {
        try
        {
            System.Console.WriteLine(message.ToString());
        }
        catch
        {
            System.Console.WriteLine(message);

        }
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


        

        

        */