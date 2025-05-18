using MauiApp1.Pagess;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("tab1/page1", typeof(MainPage));
            Routing.RegisterRoute("tab2/page2", typeof(Page2));
            Routing.RegisterRoute("tab3/page3", typeof(Page3));
        }
    }
}
