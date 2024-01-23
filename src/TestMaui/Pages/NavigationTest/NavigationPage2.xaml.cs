namespace TestMaui.Pages.NavigationTest;

public partial class NavigationPage2 : ContentPage
{
	public NavigationPage2()
	{
		InitializeComponent();
	}

    private async void OnNavigate(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();

		var modalStack = Navigation.ModalStack;
		var NavigationStack = Navigation.NavigationStack;
    }
}