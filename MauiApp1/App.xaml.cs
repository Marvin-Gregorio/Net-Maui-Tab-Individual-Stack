namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell())
            { 
                Width = 768,
                Height = 900,
                X = 0,
                Y = 0
            };
        }
    }
}