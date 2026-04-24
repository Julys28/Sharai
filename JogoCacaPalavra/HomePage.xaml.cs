using Microsoft.Maui.Controls;

namespace JogoCacaPalavra
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnStartClicked(object sender, System.EventArgs e)
        {
            // Navigate to the existing MainPage (game)
            await Shell.Current.GoToAsync("/MainPage");
        }
    }
}
