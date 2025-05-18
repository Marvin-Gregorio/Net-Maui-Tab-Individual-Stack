using System.Threading.Tasks;

namespace MauiApp1.Components;

public partial class Header : ContentView
{
	public Header()
	{
		InitializeComponent();
	}

	public void GoToPage1(object sender, EventArgs e)
	{
        Shell.Current.CurrentItem = Shell.Current.Items[0].Items[0];
    }

    public void GoToPage2(object sender, EventArgs e)
    {
        Shell.Current.CurrentItem = Shell.Current.Items[0].Items[1];
    }

    public void GoToPage3(object sender, EventArgs e)
    {
        Shell.Current.CurrentItem = Shell.Current.Items[0].Items[2];
    }
}