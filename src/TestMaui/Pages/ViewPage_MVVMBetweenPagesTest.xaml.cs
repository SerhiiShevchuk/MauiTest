using TestMaui.ViewModels;

namespace TestMaui.Pages;

public partial class ViewPage_MVVMBetweenPagesTest : ContentPage
{
    public SimpleViewModel Model{ get; set; }

    public ViewPage_MVVMBetweenPagesTest()
	{
		InitializeComponent();

        Model = new SimpleViewModel() {Value = "InitialValue" };

        BindingContext = Model;
    }

    private void OnNavegate(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EntryPage_MVVMBetweenPagesTest(Model.Value));
    }
}

public class TestObj
{
    string value;
}
