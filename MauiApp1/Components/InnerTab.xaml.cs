using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using ShellItem = Microsoft.Maui.Controls.ShellItem;

namespace MauiApp1.Components;

public partial class InnerTab : ContentView
{
	public InnerTab()
	{
		InitializeComponent();
	}

    public async void GoToPage1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("page1");
    }

    public async void GoToPage2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("page2");
    }

    public async void GoToPage3(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("page3");
    }

    public async void ResetStack(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopToRootAsync();
    }
}