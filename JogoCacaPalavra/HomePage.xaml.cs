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
            await Shell.Current.GoToAsync("//MainPage");
        }
    }
}
