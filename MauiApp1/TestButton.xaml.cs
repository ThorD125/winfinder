using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Maui.Devices.Sensors;

namespace MauiApp1;

public partial class TestButton : button
{
    private string defaultlocation;

    public TestButton(string text, string defaultlocation)
	{
        this = new Button();
        this.text = text;
        this.defaultlocation = defaultlocation;
    }

    public string getAttribute(string attribute){
        return this.get(attribute).ToString;
    }

}
