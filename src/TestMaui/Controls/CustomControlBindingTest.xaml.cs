namespace TestMaui.Controls;

public partial class CustomControlBindingTest : ContentView
{

    public static readonly BindableProperty TagProperty =
        BindableProperty.Create(nameof(Tag),
        typeof(string),
        typeof(CustomControlBindingTest),
        "0",
        defaultBindingMode: BindingMode.TwoWay
    );

    public string Tag
    {
        set => SetValue(TagProperty, value);
        get => (string)GetValue(TagProperty);
    }

    public CustomControlBindingTest()
    {
        InitializeComponent();
    }
}