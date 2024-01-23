namespace TestMaui.Pages;

public partial class EntryPage_MVVMBetweenPagesTest : ContentPage
{
	public string EntryValuee { get; set; }

	public EntryPage_MVVMBetweenPagesTest(string entryValuee)
	{
		InitializeComponent();

		EntryValuee = entryValuee;

		BindingContext = this;
    }

    private void OnNavigate(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}