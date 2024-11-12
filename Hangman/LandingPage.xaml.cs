using Microsoft.Maui.Controls;

namespace Hangman;

public partial class LandingPage : ContentPage
{
	public LandingPage()
	{
		InitializeComponent();
	}


	private async void OnPlayButtonClicked(object sender, EventArgs e)
    {
        // Navigate to the MainPage when the Play button is clicked
        await Navigation.PushAsync(new MainPage());
    }
}