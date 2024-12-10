using System.Net.WebSockets;

namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AbsoluteLayoutDemo());
        }
    }
}
