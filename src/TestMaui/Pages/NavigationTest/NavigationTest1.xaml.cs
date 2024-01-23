namespace TestMaui.Pages.NavigationTest;

public partial class NavigationTest1 : ContentPage
{
	public NavigationTest1()
	{
		InitializeComponent();
	}

    private void OnNavigate(object sender, EventArgs e)
    {
		Navigation.PushAsync(new NavigationPage2());
    }
}