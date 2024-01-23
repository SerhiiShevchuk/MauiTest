namespace TestMaui;

public partial class PagePropToControlBindingTest : ContentPage
{
    //public static readonly BindableProperty CurrentProperty =
    //        BindableProperty.Create(nameof(Current), // название обычного свойства
    //        typeof(string), // возвращаемый тип 
    //        typeof(PagePropToControlBindingTest), // тип,  котором объявляется свойство
    //        "0"// значение по умолчанию
    //        );

    //public string Current
    //{
    //    set => SetValue(CurrentProperty, value);
    //    get => (string)GetValue(CurrentProperty);
    //}

    public string Current { get; set; }

    public PagePropToControlBindingTest()
	{


        InitializeComponent();

        Current = "Constructor";

        BindingContext = this;
	}

    private void Test(object sender, EventArgs e)
    {

    }
}