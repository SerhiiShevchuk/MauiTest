namespace TestMaui.Pages.NavigationTest;

public partial class NavigationPage2 : ContentPage
{
	public NavigationPage2()
	{
		InitializeComponent();
	}

    private async void OnNavigate(object sender, EventArgs e)
    {
        var modalStack = Navigation.ModalStack;
        var NavigationStack = Navigation.NavigationStack;

        await Navigation.PopModalAsync();

        await Navigation.PopToRootAsync();

		modalStack = Navigation.ModalStack;
		NavigationStack = Navigation.NavigationStack;
    }
}