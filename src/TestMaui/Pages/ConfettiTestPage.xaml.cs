using SkiaSharp.Extended.UI.Controls;

namespace TestMaui.Pages;

public partial class ConfettiTestPage : ContentPage
{
	public ConfettiTestPage()
	{
		InitializeComponent();
	}

    private void OnAnimationEnabled(object sender, EventArgs e)
    {
        SKLottieView_1.IsAnimationEnabled = true;


        SKLottieView_1.RepeatCount = 10;

        SKLottieView_1.IsVisible = true;
    }

    private void OffAnimationEnabled(object sender, EventArgs e)
    {
        SKLottieView_1.IsAnimationEnabled = false;

        SKLottieView_1.RepeatCount = 0;

        //SKLottieView_1.IsVisible = false;
    }

    protected virtual void OnAppearing()
    {
        Task.Delay(1000).Wait();
    }
}