using TestMaui.Pages;
using TestMaui.Pages.NavigationTest;

namespace TestMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainNavigatonPage());
        }
    }
}