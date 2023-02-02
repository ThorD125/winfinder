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
    private settings settings = new settings();

    public MainPage()
	{
		InitializeComponent();
        inputBox.Text = defaultPath;
        LoadGroup();
    }
    public void showListview(object sender, EventArgs args)
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
    public void showListViewForPath(object sender, EventArgs args)
    {
        mybottton newsender = (mybottton)sender;
        inputBox.Text = newsender.defaultPath + newsender.Text;
        ClearGroup();
        LoadGroup();
    }
    public void showFile(object sender, EventArgs args)
    {
        Log("showListViewForPath");
        mybottton newsender = (mybottton)sender;
        inputBox.Text = newsender.defaultPath + newsender.Text;
        ClearGroup();
        LoadGroup();
    }

    private void doFolderStuff(mybottton item)
    {
        item.Clicked += showListViewForPath;
    }

    private void doFileStuff(mybottton item)
    {
        item.Clicked += showFile;
    }
    private void addItems(VerticalStackLayout listView, string defaultlocation, string[] items, string filetype)
    {
        double widthCollumn = 0;
        double count = 0;

        foreach (string itemName in items)
        {
                string newItemName = itemName.Remove(0, defaultlocation.Length);



            if (
                (!newItemName.StartsWith(".") || (newItemName.StartsWith(".") && settings.viewHiddenFiles)) &&
                    (!newItemName.StartsWith("$") /*|| (newItemName.StartsWith("$") && settings.viewHiddenFiles)*/)
                    )
            {
                HorizontalStackLayout div = new HorizontalStackLayout();

                mybottton item = new mybottton();
                item.Text = newItemName;

                item.defaultPath = defaultlocation;
                item.fileType = filetype;

                if (filetype == "f")
                {
                    doFolderStuff(item);
                }
                else if (filetype == "d")
                {
                    doFileStuff(item);
                }



                //TODO change to img
                Label image = new Label();
                image.Text = filetype;

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
        Log(NewLocation);

        VerticalStackLayout listView = new VerticalStackLayout();

        Border border = new Border
        {
            Stroke = Color.FromArgb("#ffffbb00"),
            Background = Color.FromArgb("#ff000000"),
            StrokeThickness = 4,
            Content = listView,
        };



        addItems(listView, NewLocation, Directory.GetDirectories(NewLocation), "d");
        addItems(listView, NewLocation, Directory.GetFiles(NewLocation), "f");

        //divLists.Add(listView);
        divLists.Add(border);

    }


    private void ClearGroup()
    {
        Log("explorerTable.Clear");
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
