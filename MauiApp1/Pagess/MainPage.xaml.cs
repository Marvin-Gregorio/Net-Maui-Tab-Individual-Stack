using System.Diagnostics;

namespace MauiApp1.Pagess
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Debug.WriteLine("main page 1");
        }
    }
}
