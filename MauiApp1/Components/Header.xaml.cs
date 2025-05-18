using MauiApp1.Constants;
using MauiApp1.Pagess;

namespace MauiApp1.Components;

public partial class Header : ContentView
{
	public Header()
	{
		InitializeComponent();
	}

	public void GoToPage1(object sender, EventArgs e)
	{
        Shell.Current.CurrentItem = NavigationRoutes.tab1;
    }

    public void GoToPage2(object sender, EventArgs e)
    {
        Shell.Current.CurrentItem = NavigationRoutes.tab2;
    }

    public void GoToPage3(object sender, EventArgs e)
    {
        Shell.Current.CurrentItem = NavigationRoutes.tab3;
    }

    public async void ReinitializeTab1AndGoToTab1(object sender, EventArgs e)
    {
        this.ResetPage<Base>();
        await Shell.Current.GoToAsync($"//{NavigationRoutes.tab1.Route}");
        
        
    }

    private void ResetPage<TPage>() where TPage : Page
    {
        var section = Shell.Current.CurrentItem?.CurrentItem;
        var oldContent = section?.CurrentItem as ShellContent;  

        if (oldContent != null)
        {
            section.Items[section.Items.IndexOf(oldContent)] = new ShellContent
            {
                Title = oldContent.Title,
                Icon = oldContent.Icon,
                Route = oldContent.Route,
                ContentTemplate = new DataTemplate(typeof(TPage))
            };
        }
    }
}