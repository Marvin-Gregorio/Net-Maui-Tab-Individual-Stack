using MauiApp1.Pagess;
using MauiApp1.Constants;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.RegisterPageRoute();
            this.PopulateTabConstants();
        }

        private void PopulateTabConstants()
        {
            Dispatcher.Dispatch(() => {
                NavigationRoutes.tab1 = Shell.Current.Items[0].Items[0];
                NavigationRoutes.tab2 = Shell.Current.Items[0].Items[1];
                NavigationRoutes.tab3 = Shell.Current.Items[0].Items[2];
            });
        }

        private void RegisterPageRoute()
        {
            Routing.RegisterRoute("tab1/page1", typeof(MainPage));
            Routing.RegisterRoute("tab2/page2", typeof(Page2));
            Routing.RegisterRoute("tab3/page3", typeof(Page3));
        }
    }
}
