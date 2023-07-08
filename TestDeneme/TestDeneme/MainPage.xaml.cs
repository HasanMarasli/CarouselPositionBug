using MHZ.MBL.DelailulHayrat.MAUI;
using TestDeneme.models;
namespace TestDeneme;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new IntroScreenViewModel();
        OnBoardingCarouselView.Position = 5;

        //CarouselIndicator.IsVisible = false;
        CarouselIndicator.Position = 5;
    }

    private async void HandleNextButtonClick(object sender, EventArgs e)
    {
        if (OnBoardingCarouselView.Position + 1 < new IntroScreenViewModel().GunlerList.Count)
            OnBoardingCarouselView.Position++;
    }



}

