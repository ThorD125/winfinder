using System.Runtime.CompilerServices;
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

    public void resetlocation(object sender, EventArgs args) {
        Log("sefesfesfesf");
        Button newsender = (Button) sender;
        inputBox.Text = newsender.Text;
    }

    private void addItems(VerticalStackLayout listView, string defaultlocation, string[] items, string filetype)
    {
        Log("start" + items);
        
        double widthCollumn = 0;
        double count = 0;

        foreach (string itemName in items)
        {
            HorizontalStackLayout div = new HorizontalStackLayout();



            Button item = new Button();
            string newItemName = itemName.Remove(0, defaultlocation.Length);
            item.Text = newItemName;


            item.Clicked += resetlocation;

            
            //TODO change to img
            Label image = new Label();
            image.Text = filetype;

            widthCollumn += newItemName.Length*10;
            count++;

            div.Add(image);
            div.Add(item);
            listView.Add(div);

        }

        double result = (widthCollumn / count)*1.1;
        listView.WidthRequest = result;
    }
    private void NewColumn(string NewLocation)
    {
        Log(NewLocation);

        VerticalStackLayout listView = new VerticalStackLayout();
        
        addItems(listView, NewLocation, Directory.GetDirectories(NewLocation), "d");
        addItems(listView, NewLocation, Directory.GetFiles(NewLocation), "f");

        divLists.Add(listView);
        //String[] foldersandfiles = folders.Union(files).ToArray();

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
