using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Graphics.Text;
using static System.Net.Mime.MediaTypeNames;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    readonly string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    private readonly settings settings = new();

    public MainPage()
	{
		InitializeComponent();
        inputBox.Text = defaultPath;
        LoadGroup();
    }
    public void ShowListview(object sender, EventArgs args)
    {
        ClearGroup();
        LoadGroup();
    }


    public void LoadGroup()
    {
        string[] Locations = inputBox.Text.Split('\\');
        string result = "";

        foreach (string location in Locations)
        {
            result += location + '\\';
            NewColumn(result);
        }
    }
    public void ShowListViewForPath(object sender, EventArgs args)
    {
        mybottton newsender = (mybottton)sender;
        inputBox.Text = newsender.defaultPath + newsender.Text;
        ClearGroup();
        LoadGroup();
    }
    public void ShowFile(object sender, EventArgs args)
    {
        //Log("showListViewForPath");
        mybottton newsender = (mybottton)sender;
        inputBox.Text = newsender.defaultPath + newsender.Text;
        ClearGroup();
        LoadGroup();
    }

    private void DoFolderStuff(mybottton item)
    {
        item.Clicked += ShowListViewForPath;
    }

    private void DoFileStuff(mybottton item)
    {
        item.Clicked += ShowFile;
    }

    private bool IsNotHiddenFile(string newItemName)
    {
        return (!newItemName.StartsWith(".") || (newItemName.StartsWith(".") && settings.viewHiddenFiles))
            && (!newItemName.StartsWith("$"))
            ;
    }
    private void AddItems(VerticalStackLayout listView, string defaultlocation, string[] items, string filetype)
    {
        double widthCollumn = 0;
        double count = 0;

        foreach (string itemName in items)
        {
            string newItemName = itemName.Remove(0, defaultlocation.Length);
            bool accesible = false;


            try
            {
                Log(Directory.GetDirectories(itemName));
                accesible = true;
            }
            catch { }
            try
            {
                Log(Directory.GetFiles(itemName));
                accesible = true;
            }
            catch { }


            if (
                    IsNotHiddenFile(newItemName)
                    && accesible
                    )
            {
                HorizontalStackLayout div = new();

                mybottton item = new()
                {
                    Text = newItemName,

                    defaultPath = defaultlocation,
                    fileType = filetype
                };

                if (filetype == "f")
                {
                    DoFolderStuff(item);
                }
                else if (filetype == "d")
                {
                    DoFileStuff(item);
                }



                //TODO change to img
                Label image = new()
                {
                    Text = filetype
                };

                widthCollumn += newItemName.Length * 10;
                count++;

                div.Add(image);
                div.Add(item);
                listView.Add(div);
            }
        }
        double result = (widthCollumn / count)*1.1;
        listView.WidthRequest = result;
    }
    private void NewColumn(string NewLocation)
    {
        //Log(NewLocation);

        VerticalStackLayout listView = new();

        Border border = new()
        {
            Stroke = Color.FromArgb("#ffffbb00"),
            Background = Color.FromArgb("#ff000000"),
            StrokeThickness = 4,
            Content = listView,
            MinimumWidthRequest = 200,
        };



        AddItems(listView, NewLocation, Directory.GetDirectories(NewLocation), "d");
        AddItems(listView, NewLocation, Directory.GetFiles(NewLocation), "f");

        //divLists.Add(listView);
        divLists.Add(border);

    }


    private void ClearGroup()
    {
        //Log("explorerTable.Clear");
        divLists.Clear();
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
