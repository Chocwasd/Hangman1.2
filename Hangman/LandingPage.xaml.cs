using Plugin.Maui.Audio;
using System;
using Microsoft.Maui.Controls;
using System.Threading;

namespace Hangman
{
    public partial class LandingPage : ContentPage
    {
        // Declare the audio player instance and timer
        private IAudioPlayer _audioPlayer;
        private Timer _loopTimer;

        public LandingPage()
        {
            InitializeComponent();

            // Hide the navigation bar on LandingPage (optional)
            NavigationPage.SetHasNavigationBar(this, false);

            // Play background music when LandingPage is initialized
            PlayBackgroundMusic();
        }

        private async void OnPlayButtonClicked(object sender, EventArgs e)
        {
            // Navigate to MainPage and remove navigation bar for MainPage
            var mainPage = new MainPage();
            NavigationPage.SetHasNavigationBar(mainPage, false);

            await Navigation.PushAsync(mainPage);
        }

        private async void PlayBackgroundMusic()
        {
            // Get the music file from resources
            var file = await FileSystem.OpenAppPackageFileAsync("Resources/Audio/backgroundmusic.mp3");

            // Create the audio player
            _audioPlayer = AudioManager.Current.CreatePlayer(file);

            // Play the music
            _audioPlayer.Play();

            // Start a timer to check if the music has finished
            _loopTimer = new Timer(CheckAudioPlayback, null, 0, 1000);  // Check every second
        }

        // Method to check if the audio has finished
        private void CheckAudioPlayback(object state)
        {
            // The Plugin.Maui.Audio does not expose the state, so we rely on the time position check instead
            // If the audio has finished playing, restart it
            if (_audioPlayer.CurrentPosition >= _audioPlayer.Duration)
            {
                _audioPlayer.Play(); // Restart the music
            }
        }

        private void StopBackgroundMusic()
        {
            // Stop the music and dispose of the timer
            _audioPlayer?.Stop();
            _loopTimer?.Dispose();
        }
    }
}
