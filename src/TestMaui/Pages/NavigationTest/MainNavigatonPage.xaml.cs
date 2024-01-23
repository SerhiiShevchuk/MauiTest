namespace TestMaui.Pages.NavigationTest;

public partial class MainNavigatonPage : ContentPage
{
	public MainNavigatonPage()
	{
		InitializeComponent();
	}

    private void OnNavigate(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new NavigationPage(new NavigationTest1()));
    }
}